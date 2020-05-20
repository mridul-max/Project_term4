using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class PaymentScreen : Form
    {
        private Order CurrentPayment;
        private TableService tableService = new TableService();
        private OrderService orderService = new OrderService();

        public PaymentScreen(Table table)
        {
            InitializeComponent();
            CurrentPayment = orderService.GetOrderByTableId(table.TableNumber);
         


        }

        private void PaymentScreen_Load(object sender, EventArgs e)
        {
            if(CurrentPayment!=null)
            FillListView();

        }
        public void FillListView()
        {
           
            listViewOrders.Clear();
            ColumnHeader MenuItemName = new ColumnHeader();
            MenuItemName.Text ="Menu item name";
            ColumnHeader Amount = new ColumnHeader();
            Amount.Text = "Amount";
            ColumnHeader Category = new ColumnHeader();
            Category.Text = "Category";
            ColumnHeader CategoryType = new ColumnHeader();
            CategoryType.Text = "Category Type";


            listViewOrders.Columns.AddRange(new ColumnHeader[] { MenuItemName, Amount, Category, CategoryType});

            foreach (OrderItem order in CurrentPayment.OrderItems)
            {
                ListViewItem li = new ListViewItem(order.MenuItem.Name);
                li.SubItems.Add(order.Amount.ToString());
                li.SubItems.Add(order.MenuItem.Category);
                li.SubItems.Add(order.MenuItem.CategoryType.ToString());
                listViewOrders.Items.Add(li);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Checks out and makes the table empty again.
        private void btnApply_Click(object sender, EventArgs e)
        {
          
        }
        private void FillPrices()
        {

        }
    }
}
