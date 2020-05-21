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
    public partial class ManagerScreen : Form
    {
        private Employee loggedEmployee;
        public ManagerScreen()
        {
            InitializeComponent();                           
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            lblLogged.Text = lblLogged.Text + " " + Employee.LoggedEmployee.Name;
        }

        private void ManagerScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kitchenbarScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitchenBarScreen kitchenBarView = new KitchenBarScreen();
            this.Hide();
            kitchenBarView.ShowDialog();
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableView tableView = new TableView();
            this.Hide();
            tableView.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }
    }
}
