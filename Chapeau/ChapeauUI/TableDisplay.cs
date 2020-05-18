using ChapeauLogic;
using ChapeauModel;
using ChapeauUI.UserControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class TableDisplay : Form
    {
        private Table CurrentTable;
        private Order CurrentTicket;
        private TableService tableService = new TableService();
        private ReservationService reservationService = new ReservationService();
        private List<Reservation> reservations;
        private List<OrderItem> orderItems;
        public TableDisplay(Table CurrentTable)
        {
            InitializeComponent();
            this.CurrentTable = CurrentTable;
            CurrentTicket = new Order();
            CurrentTicket.TableNr = CurrentTable.TableNumber;
        }

        private void TableDisplay_Load(object sender, EventArgs e)
        {
            FillTableInformation();
            UpdateTableView();
            FillCurrentOrders();
        }
        private void UpdateTableView()
        {
            reservations = reservationService.GetAllReservations();
            comboBox1.Items.Clear();
            foreach (Reservation reservation in reservations)
            {
                if (reservation.TableNumber == CurrentTable.TableNumber && reservation.ReservationDate >= DateTime.Now)
                    comboBox1.Items.Add(reservation.ReserverName + "  " + reservation.ReservationDate.ToString());
            }
            if (CurrentTable.IsOccupied)
            {
                BtnChout.Enabled = true;
            }
            else
            {
                BtnChout.Enabled = false;
            }
        }
        //fills the labels according to the information.
        void FillTableInformation()
        {
            lblTableNumber.Text = lblTableNumber.Text + " " + CurrentTable.TableNumber.ToString();
            lblCapacity.Text = lblCapacity.Text + " " + CurrentTable.Capacity.ToString();
            if (CurrentTable.IsOccupied)
                lblOccupy.Text = lblOccupy.Text + " " + "Occupied";
            else
                lblOccupy.Text = lblOccupy.Text + " " + "Empty";
        }
        void FillCurrentOrders()
        {
            orderItems = tableService.GetOrderItemsofTable(CurrentTable.TableNumber);
            UCCurrentOrders orderUC;
            foreach (OrderItem item in orderItems)
            {
                orderUC = new UCCurrentOrders(item);
                pnlCurrentOrders.Controls.Add(orderUC);
            }
        }

        private void Btnreserve_Click(object sender, EventArgs e)
        {
            ReservationForm form = new ReservationForm(CurrentTable);
            form.ShowDialog();
            UpdateTableView();
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OrderingScreen screen = new OrderingScreen(CurrentTable);
            screen.ShowDialog();
            UpdateTableView();
        }

        private void BtnChout_Click(object sender, EventArgs e)
        {
            PaymentScreen screen = new PaymentScreen(CurrentTicket);
            screen.ShowDialog();
            UpdateTableView();
        }


    }
}
