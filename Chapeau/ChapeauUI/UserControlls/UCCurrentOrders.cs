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
            
            //There is no served order because it does not appear in waiter's screen if the order is served.
            
            if (orderItem.orderState == OrderState.ReadyToDeliver)
            {
                lblStatus.Text = "Ready to deliver";
                lblTimer.Text = string.Empty;
                btnServed.Visible = true;
                //if this order item is ready to deliver and not something else, make the button visible.
            }
            else if(orderItem.orderState==OrderState.PrepairingOrder)
            {
                lblStatus.Text = "Preparing order";
            }
            else
            {
                lblStatus.Text = "Running order";               
            }                 
           
                timer.Tick += Timer_Tick;
                timer.Interval = 1000;
                timer.Start();                     

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
            OrderService service = new OrderService(); //Since i will only use it in this button method, I create the object here.

            service.SetOrderItemAsServed(orderItem);
            this.Hide();
            
        }
    }
}
