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
        public OrderItem OrderItem { get; }
        public Label AmountLabel { get { return lblAmount; } }
        public Label currentOrderLabel;
        public int Amount 
        { 
            get { return OrderItem.Amount; }
            set
            {
                if (value >= 0)
                {
                    OrderItem.Amount = value;
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
            OrderItem = new OrderItem(menuItem, amount);
            lblAmount.Text = Amount.ToString();
            lblName.Text = menuItem.Name;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(Amount > 0)
            {
                Amount--;
                mainScreen.UpdateCurrentOrderItem(this);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Amount < OrderItem.MenuItem.Stock)
            {
                Amount++;
                mainScreen.UpdateCurrentOrderItem(this);
            }
            else
            {
                MessageBox.Show($"{OrderItem} has only {OrderItem.MenuItem.Stock} items left in stock");
            }
        }
    }
}
