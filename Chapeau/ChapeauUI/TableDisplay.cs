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
        
        ReservationService reservationService = new ReservationService();
        List<Reservation> reservations;
        public TableDisplay(Table CurrentTable)
        {
            InitializeComponent();
            this.CurrentTable = CurrentTable;

        }

        private void TableDisplay_Load(object sender, EventArgs e)
        {
            FillTableInformation();
            reservations = reservationService.GetAllReservations();
            comboBox1.Items.Clear();
            foreach (Reservation reservation in reservations)
            {
                if (reservation.TableNumber == CurrentTable.TableNumber && reservation.ReservationDate >= DateTime.Now)
                    comboBox1.Items.Add(reservation.ReserverName + reservation.ReservationDate.ToString());
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
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OrderingScreen screen = new OrderingScreen(CurrentTable);
            screen.ShowDialog();
        }   

        private void BtnChout_Click(object sender, EventArgs e)
        {

        }
    }
}
