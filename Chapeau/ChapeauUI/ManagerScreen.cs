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
        public ManagerScreen()
        {
            InitializeComponent();                           
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            EditEmployee edit = new EditEmployee();
            this.Hide();
            edit.ShowDialog();
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {

        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {

        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {

        }
    }
}
