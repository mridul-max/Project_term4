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
        public ManagerScreen(Employee loggedEmployee)
        {
            InitializeComponent();
            this.loggedEmployee = loggedEmployee;                   
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            lblLogged.Text = lblLogged.Text+ " "+ loggedEmployee.Name;
        }

        private void ManagerScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableView tableView = new TableView(loggedEmployee);
            this.Hide();
            tableView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitchenBarScreen kitchenBarView = new KitchenBarScreen(loggedEmployee);
            this.Hide();
            kitchenBarView.ShowDialog();
        }
    }
}
