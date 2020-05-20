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
            try
            {
                services.CreateNewOrder(mainScreen.GetCurrentOrder());
            }
            catch
            {
                throw;
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