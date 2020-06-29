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
using ChapeauLogic;

namespace ChapeauUI.UserControlls
{
    public partial class UCCurrentOrders : UserControl
    {

        private Timer timer;
        OrderService service;


        private OrderItem orderItem { get; set; }
        public UCCurrentOrders(OrderItem orderItem)
        {
            InitializeComponent();
            timer = new Timer();
            service = new OrderService();
            this.orderItem = orderItem;
        }


        private void UCCurrentOrders_Load(object sender, EventArgs e)
        {
            lblItemName.Text = orderItem.MenuItem.Name;
            lblAmount.Text = orderItem.Amount.ToString();

            UpdateLabels();
            StartTimer();
        }
        private void StartTimer()
        {
            
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            
            if (orderItem.orderState != OrderState.OrderServed)
            {
                timer.Start();
            }
            else
            {
                Timer_Tick(this, EventArgs.Empty);
            }

        }
        private void UpdateLabels()
        {
            //There is no served order because it does not appear in waiter's screen if the order is served.

            if (orderItem.orderState == OrderState.ReadyToDeliver)
            {
                lblStatus.Text = "Ready to deliver";
                btnRemake.Visible = false;
                btnServed.Visible = true;
                //if this order item is ready to deliver and not something else, make the button visible.
            }
            else if (orderItem.orderState == OrderState.PrepairingOrder)
            {
                lblStatus.Text = "Preparing order";
                btnRemake.Visible = false;
                btnServed.Visible = false;
            }
            else
            {
                lblStatus.Text = "Order is served";               
                btnRemake.Visible = true;
                btnServed.Visible = false;
            }

        }
        //We are getting it again to have the most current version.
        private void RefreshOrderItem()
        {
            orderItem = service.GetOrderItemsById(orderItem);
            UpdateLabels();

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

        private void btnServed_Click(object sender, EventArgs e)
        {
            service.SetOrderItemAsServed(orderItem);
            btnRemake.Visible = true;
            timer.Stop();
            RefreshOrderItem();

        }

        //For remaking the order.
        private void button1_Click(object sender, EventArgs e)
        {
            service.UpdatePreparingItem(orderItem);
            timer.Start();
            RefreshOrderItem();

        }
    }
}
