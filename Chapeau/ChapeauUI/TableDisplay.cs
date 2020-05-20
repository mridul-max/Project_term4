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
        private OrderService orderService;
        private ReservationService reservationService;
        private List<Reservation> reservations;
        private List<OrderItem> orderItems;
        private TableService tableService;
        public TableDisplay(Table currentTable)
        {
            InitializeComponent();

            orderService = new OrderService();
            reservationService = new ReservationService();
            tableService = new TableService();
            this.CurrentTable = tableService.GetById(currentTable.TableNumber);
        }

        private void TableDisplay_Load(object sender, EventArgs e)
        {
            FillTableInformation();
            UpdateTableView();

        }
        //Fills the current order and displays the current reservations for the current table.
        private void UpdateTableView()
        {
            FillCurrentOrders();
            reservations = reservationService.GetAllReservations();
            comboBox1.Items.Clear();
            foreach (Reservation reservation in reservations)
            {
                if (reservation.TableNumber == CurrentTable.TableNumber && reservation.ReservationDate >= DateTime.Now)
                    comboBox1.Items.Add(reservation.ReserverName + "  " + reservation.ReservationDate.ToString());
            }
            //If table has no orders yet, user is unable to check out even if the table is occupied.
            if (orderItems.Count<=0)
            {
                BtnChout.Enabled = false;        
            }
            else
            {
                BtnChout.Enabled = true;
            }
        }


        //fills the labels according to the information.
        void FillTableInformation()
        {
            lblTableNumber.Text = "Table Number:" + " " + CurrentTable.TableNumber.ToString();
            lblCapacity.Text = "Capacity:" + " " + CurrentTable.Capacity.ToString();
            if (CurrentTable.IsOccupied)
                lblOccupy.Text = "Occupancy: Occupied";
            else
                lblOccupy.Text = "Occupancy:  Empty";
        }


        //Displays each order one by one in user control with timer.
        void FillCurrentOrders()
        {
            orderItems = orderService.GetUnfinishedOrdersOfTable(CurrentTable.TableNumber);
            UCCurrentOrders orderUC;
            if(pnlCurrentOrders.Controls.Count>0)
            {
                pnlCurrentOrders.Controls.Clear(); //Clearing for having more up to date  information.
            }
            foreach (OrderItem item in orderItems)
            {
                orderUC = new UCCurrentOrders(item);
                pnlCurrentOrders.Controls.Add(orderUC);
            }
        }


        //opens reservation screen
        private void Btnreserve_Click(object sender, EventArgs e)
        {
            ReservationForm form = new ReservationForm(CurrentTable);
            form.ShowDialog();
            UpdateTableView();
        }


        //opens ordering screen
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OrderingScreen screen = new OrderingScreen(CurrentTable);
            screen.ShowDialog();
            UpdateTableView();
        }


        //opens payment screen.
        private void BtnChout_Click(object sender, EventArgs e)
        {
            PaymentScreen screen = new PaymentScreen(CurrentTable);
            screen.ShowDialog();
            UpdateTableView();
        }


        //closes this tab and returns to tableview.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Sets the table to occupied as requested in pdf.
        private void btnOccupy_Click(object sender, EventArgs e)
        {
            if (!CurrentTable.IsOccupied)
            {
                tableService.SetOccupied(CurrentTable.TableNumber);
                CurrentTable.IsOccupied = true;
                UpdateTableView();
                FillTableInformation(); // Refreshing the labels.

                //SHOULD I ALSO CREATE AN EMPTY PAYMENT SINCE THE TABLE IS OCCUPIED??
            }
        }
    }
}
