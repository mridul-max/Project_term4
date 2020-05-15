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
        public ChapeauModel.MenuItem MenuItem { get; }
        public Label AmountLabel { get { return lblAmount; } }
        public Label currentOrderLabel;
        private int amount;
        public int Amount 
        { 
            get { return amount; }
            set
            {
                if (value >= 0)
                {
                    amount = value;
                    lblAmount.Text = Amount.ToString();
                    if(currentOrderLabel != null)
                        currentOrderLabel.Text = Amount.ToString();
                }
            }
        }
        private OrderingScreen mainScreen;
        public OrderingRow(OrderingScreen mainScreen, ChapeauModel.MenuItem menuItem, int amount = 0)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            MenuItem = menuItem;
            Amount = amount;
            lblAmount.Text = Amount.ToString();
            lblName.Text = menuItem.Name;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(Amount != 0)
            {
                Amount--;
                mainScreen.UpdateCurrentOrderItem(this);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Amount++;
            mainScreen.UpdateCurrentOrderItem(this);
        }
    }
}
