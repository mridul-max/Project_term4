using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class OrderingConfirmation : UserControl
    {
        OrderingScreen mainScreen;
        OrderService services;
        public OrderingConfirmation(OrderingScreen screen)
        {
            InitializeComponent();
            mainScreen = screen;
            services = new OrderService();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Order order = mainScreen.GetCurrentOrder();
            if (order.OrderItems.Count < 1)
                return;

            try
            {
                services.CreateNewOrder(order);
            }
            catch
            {
                //throw;
            }
            finally
            {
                mainScreen.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainScreen.Close();
        }        
    }
}