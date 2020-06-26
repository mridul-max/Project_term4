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
        /// <summary>
        /// Current amount of the menuItem in this row
        /// </summary>
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
        public bool first;
        private OrderingScreen mainScreen;
        public OrderingRow(OrderingScreen mainScreen, ChapeauModel.MenuItem menuItem, bool showEdit = false, int amount = 0)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            OrderItem = new OrderItem(menuItem, amount);
            lblAmount.Text = Amount.ToString();
            lblName.Text = menuItem.Name;
            btnEdit.Visible = false;
        }

        /// <summary>
        /// Remove one from the item amount
        /// </summary>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(Amount > 0)
            {
                Amount--;
                mainScreen.UpdateCurrentOrderItem(this);
            }
        }
        /// <summary>
        /// Add one to the item amount
        /// </summary>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            // check the there is enough stock
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void OrderingRow_Paint(object sender, PaintEventArgs e)
        {
            if (!first)
            {
                Pen pen = new Pen(Color.FromArgb(200, 0, 0, 0));
                e.Graphics.DrawLine(pen, lblName.Bounds.Left + 30, lblName.Bounds.Top, lblName.Bounds.Right - 30, lblName.Bounds.Top);
            }
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
