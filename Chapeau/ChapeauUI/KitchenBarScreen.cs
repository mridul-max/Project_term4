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
    public partial class KitchenBarScreen : Form
    {
        
        public KitchenBarScreen()
        {
            InitializeComponent();       
        }

        private void KitchenBarScreen_Load(object sender, EventArgs e)
        {
            lblloggedinChef.Text = lblloggedinChef.Text+ " "+ Session.Instance.LoggedEmployee.Name;
            if (Session.Instance.LoggedEmployee.EmployeeType == EmployeeType.Kitchen)
            {
                managementToolStripMenuItem.Visible = true;
                showPanel("pnlKitchen");
            }
            else if(Session.Instance.LoggedEmployee.EmployeeType == EmployeeType.Bar)
            {
                managementToolStripMenuItem.Visible = true;
                showPanel("pnlBarScreen");
            }
        }
        private void showPanel(string panelName,bool refresh = true)
        {
            if (panelName == "pnlKitchen")
            {
                pnlBarScreen.Hide();
                pnlKitchen.Show();
                pnlKitchen.Visible = true;
                lblKitchenScreen.Text = "Kitchen Screen";
            }
            else if (panelName == "pnlBarScreen")
            {
                pnlKitchen.Hide();
                pnlBarScreen.Show();
                pnlBarScreen.Visible = true;
                lblKitchenScreen.Text = "Bar Screen";
            }
        }

        private void KitchenBarScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerScreen manager = new ManagerScreen();
            this.Hide();
            manager.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }
    }
}
