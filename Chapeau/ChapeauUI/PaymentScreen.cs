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
       private Payment CurrentPayment;
       private EmployeeService employeeService;
       private PaymentService paymentService;
       private Employee employee;

        public PaymentScreen(Payment CurrentPayment)
        {
            InitializeComponent();
            this.CurrentPayment = CurrentPayment;
            employeeService = new EmployeeService();
            employee = employeeService.GetById(CurrentPayment.EmployeeID);
            paymentService = new PaymentService();
        }

        private void PaymentScreen_Load(object sender, EventArgs e)
        {
            lblTbnumber.Text = lblTbnumber.Text + " " + CurrentPayment.TableNumber.ToString();
            //lblEmployee.Text = lblEmployee.Text + " " + employee.Name;
            //lblNoVAT.Text = lblNoVAT.Text + " " + CurrentPayment.TotalPriceNoVAT.ToString();
            //lblPriceVAT.Text = lblPriceVAT.Text + " " + CurrentPayment.TotalPriceVAT.ToString();


            cmbPayment.Items.Add("Cash"); // radio button
            cmbPayment.Items.Add("Debit");

        }
        public void CalculateVatprice()
        {
            //...
        }
        public void CalculateNoVatPrice()
        {
            //..
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbPayment.SelectedIndex > 0)
            {
                // pas the complete object.
                if (cmbPayment.SelectedItem.ToString() == "Cash")
                    CurrentPayment.PaymentMethod = 0;
                else if (cmbPayment.SelectedItem.ToString() == "Debit")
                    CurrentPayment.PaymentMethod = 1;
                
                paymentService.CompletePayment(CurrentPayment);
            }
            else
            {
                MessageBox.Show("Please choose a payment method", "Payment method required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
