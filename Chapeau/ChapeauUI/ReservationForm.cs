using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ReservationForm : Form
    {
       private ReservationService reservationService = new ReservationService();
       private  Table CurrentTable;
        public ReservationForm(Table CurrentTable)
        {
            InitializeComponent();
            this.CurrentTable = CurrentTable;
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            //Filling the hours and minutes.
            monthCalendar1.MinDate = DateTime.Today;
            for (int i = 9; i <22; i++)
            {
                cmbHour.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                if(i%5==0)
                cmbMinute.Items.Add(i);
            }

        }
        //verifies the information and applies if it works.
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            // Double checking fields before creating the reservations.
            if(string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a reserver name", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrEmpty(txtPhone.Text)|| System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]")) 
            {
                MessageBox.Show("Please enter a proper phone number", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
            else if (cmbHour.SelectedIndex <0 || cmbMinute.SelectedIndex<0)
            {
                MessageBox.Show("Please pick a time", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // database needed this in a string format.
                string reservationDate = monthCalendar1.SelectionStart.Year.ToString() + "-"
                   + monthCalendar1.SelectionStart.Month.ToString("00") + "-"
                   + monthCalendar1.SelectionStart.Day.ToString("00") + " " + cmbHour.SelectedItem.ToString() + ":" + cmbMinute.SelectedItem.ToString() + ":" + "00";

                reservationService.CreateReservation(CurrentTable.TableNumber,reservationDate,long.Parse(txtPhone.Text),txtName.Text);
                MessageBox.Show("Reservation is created", "Reservation status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();          
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
