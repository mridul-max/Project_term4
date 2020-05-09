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
        ReservationService reservationService = new ReservationService();
        Table CurrentTable;
        public ReservationForm(Table CurrentTable)
        {
            InitializeComponent();
            this.CurrentTable = CurrentTable;
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
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
            if(txtName.Text.Length <1)
            {
                MessageBox.Show("Please enter a reserver name", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(PhoneNM == null)
            {
                MessageBox.Show("Please enter a proper phone number", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(monthCalendar1.SelectionStart.Date==null)
            {
                MessageBox.Show("Please pick a date", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbHour.SelectedIndex ==null || cmbMinute.SelectedIndex==null)//come back to this.
            {
                MessageBox.Show("Please pick a time", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //come back to this
                DateTime Time = new DateTime(monthCalendar1.SelectionStart.Year,monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day,cmbHour.SelectedIndex,cmbMinute.SelectedIndex,0,DateTimeKind.Unspecified);
                reservationService.CreateReservation(CurrentTable.TableNumber, Time, int.Parse(PhoneNM.ToString()),txtName.Text);
            }
        }

       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

       
    }
}
