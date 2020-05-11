using ChapeauLogic;
using ChapeauModel;
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
        Table CurrentTable;
        Payment CurrentTicket;

        ReservationService reservationService = new ReservationService();
        List<Reservation> reservations;
        public TableDisplay(Table CurrentTable)
        {
            InitializeComponent();
            this.CurrentTable = CurrentTable;
            CurrentTicket = new Payment();
            CurrentTicket.TableNumber = CurrentTable.TableNumber;


        }

        private void TableDisplay_Load(object sender, EventArgs e)
        {
            FillTableInformation();
            UpdateTableView();
        }
        private void UpdateTableView()
        {
            reservations = reservationService.GetAllReservations();
            comboBox1.Items.Clear();
            foreach (Reservation reservation in reservations)
            {
                if (reservation.TableNumber == CurrentTable.TableNumber && reservation.ReservationDate >= DateTime.Now)
                    comboBox1.Items.Add(reservation.ReserverName + reservation.ReservationDate.ToString());
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
            lblTableNumber.Text = CurrentTable.TableNumber.ToString();
            lblCapacity.Text = CurrentTable.Capacity.ToString();
            if (CurrentTable.IsOccupied)
                lblOccupy.Text = "Occupied";
            else
                lblOccupy.Text = "Empty";
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
