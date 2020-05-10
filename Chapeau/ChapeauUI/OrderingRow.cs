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

namespace ChapeauUI
{
    public partial class OrderingRow : UserControl
    {
        public ChapeauModel.MenuItem menuItem;
        public int amount;
        public OrderingRow(ChapeauModel.MenuItem menuItem)
        {
            InitializeComponent();
            this.menuItem = menuItem;
            amount = 0;
            lblName.Text = menuItem.Name;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(amount != 0)
            {
                amount--;
                UpdateAmount();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            amount++;
            UpdateAmount();
        }

        private void UpdateAmount()
        {
            lblAmount.Text = amount.ToString();
        }
    }
}
