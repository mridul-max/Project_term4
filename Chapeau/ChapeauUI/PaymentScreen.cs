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
            FillListView();
            FillPrices();
        }

       //Filling the listview current order.
        private void FillListView()
        {

            listViewOrders.Clear();
            ColumnHeader MenuItemName = new ColumnHeader();
            MenuItemName.Text = "Menu item name";
            ColumnHeader Amount = new ColumnHeader();
            Amount.Text = "Amount";
            ColumnHeader Category = new ColumnHeader();
            Category.Text = "Category";
            ColumnHeader Price = new ColumnHeader();
            Price.Text = "Price";


            listViewOrders.Columns.AddRange(new ColumnHeader[] { MenuItemName, Amount, Category, Price });

            foreach (OrderItem order in CurrentPayment.OrderItems)
            {
                ListViewItem li = new ListViewItem(order.MenuItem.Name);
                li.SubItems.Add(order.Amount.ToString());
                li.SubItems.Add(order.MenuItem.Category);
                li.SubItems.Add(order.MenuItem.PriceWithVAT.ToString("0.00"));
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
            bool fieldsAreFilled = true; //If fields are field user will be able o check out

            if (String.IsNullOrEmpty(txtComment.Text))
            {
                CurrentPayment.Comment = "None";
            }
            else
            {
                CurrentPayment.Comment = txtComment.Text;

            }

            txtTip.Text = txtTip.Text.Replace('.', ',');
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTip.Text, @"^[0-9]*(?:\,[0-9]+)?$"))
            {
                fieldsAreFilled = false;
                MessageBox.Show("This field only accepts numbers!!", "Please use only numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtTip.Text))
            {
                CurrentPayment.Tip = 0;
            }
            else
            {
                CurrentPayment.Tip = float.Parse(txtTip.Text);
            }

            if (RDCash.Checked)
            {
                CurrentPayment.Method = PaymentMethod.Cash;
            }
            else if (RDPin.Checked)
            {
                CurrentPayment.Method = PaymentMethod.Pin;
            }
            else if (RDCredit.Checked)
            {
                CurrentPayment.Method = PaymentMethod.Credit;
            }
            else
            {
                fieldsAreFilled = false;
                MessageBox.Show("Please pick a payment method!!", "Payment method required.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //If the fields are filled correctly terminate the order and come back to table display.
            if (fieldsAreFilled)
            {
                
                DialogResult result = MessageBox.Show("Total Price: " + CurrentPayment.TotalPriceWithVAT.ToString("0.00") + "   Tip:" + CurrentPayment.Tip.ToString("0.00"), "Confirmation required", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    CurrentPayment.PaymentDate = DateTime.Now;
                    orderService.CompletePayment(CurrentPayment);
                    Table table = tableService.GetById(CurrentPayment.TableNr);
                    tableService.SetNoOccupied(table);
                    MessageBox.Show("Payment has completed and saved successfully.", "Payment completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }

        }
        private void FillPrices()
        {
            lblVAT.Text = "VAT:" + CurrentPayment.TotalVAT.ToString("0.00");
            lblPrice.Text = "Price:" + CurrentPayment.TotalPrice.ToString("0.00");
            lblTotalPrice.Text = "Total Price:" + CurrentPayment.TotalPriceWithVAT.ToString("0.00");

        }
    }
}
