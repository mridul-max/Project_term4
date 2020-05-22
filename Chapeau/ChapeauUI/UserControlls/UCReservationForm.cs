using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;

namespace ChapeauUI.UserControlls
{
    public partial class UCReservationForm : UserControl
    {
        private Reservation reservation;
        public UCReservationForm(Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Date:" + " " +reservation.ReservationDate.ToString();
            lblName.Text = "Name:" + " " + reservation.ReserverName;
            lblPhoneNr.Text = "Phone no:" + " " + reservation.PhoneNumber.ToString();

        }
    }
}
