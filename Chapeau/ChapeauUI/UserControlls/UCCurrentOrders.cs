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

namespace ChapeauUI.UserControlls
{
    public partial class UCCurrentOrders : UserControl
    {

        private Timer timer;

        private OrderItem orderItem { get; set; }
   


        public UCCurrentOrders(OrderItem orderItem)
        {
            InitializeComponent();
            timer = new Timer();
            this.orderItem = orderItem;
        }


        private void UCCurrentOrders_Load(object sender, EventArgs e)
        {
            lblItemName.Text = orderItem.MenuItem.Name;
            lblAmount.Text = orderItem.Amount.ToString();
            if (orderItem.orderState == OrderState.ReadyToDeliver)
            {
                lblStatus.Text = "Ready to deliver";
                lblTimer.Text = string.Empty;
            }                
            else
            {
                lblStatus.Text = "Running order";
                timer.Tick += Timer_Tick;
                timer.Interval = 1000;
                timer.Start();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int totalseconds = (int)(DateTime.Now - orderItem.DateTimeAdded).TotalSeconds;
            int totalMinutes = totalseconds / 60;
            int remainingSeconds = totalseconds % 60;

            if (totalMinutes > 10)
                pcTimer.Visible = true;

            lblTimer.Text = $"{totalMinutes.ToString("00")}:{remainingSeconds.ToString("00")}";
        }

    }
}
