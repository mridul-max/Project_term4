using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class OrderingConfirmation : UserControl
    {
        OrderingScreen mainScreen;
        public OrderingConfirmation(OrderingScreen screen)
        {
            InitializeComponent();
            mainScreen = screen;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }        
    }
}