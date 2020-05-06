using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class ChapeauApp : Form
    {
        Employee loggedEmployee;
        public ChapeauApp(Employee loggedEmployee)
        {
            InitializeComponent();
            this.loggedEmployee = loggedEmployee;
            this.ShowDialog();
        }

        private void ChapeauApp_Load(object sender, EventArgs e)
        {

        }
    }
}
