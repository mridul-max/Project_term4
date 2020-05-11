﻿using ChapeauLogic;
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
        Payment CurrentPayment;
        EmployeeService employeeService;
        PaymentService paymentService;
        Employee employee;
        
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
            

            cmbPayment.Items.Add("Cash");
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
            if(cmbPayment.SelectedIndex>0)
            {
                if(cmbPayment.SelectedItem.ToString()== "Cash")
                paymentService.CreatePayment(CurrentPayment.PaymentID,CurrentPayment.TableNumber,CurrentPayment.EmployeeID,CurrentPayment.TotalPriceNoVAT,CurrentPayment.TotalPriceVAT,1,DateTime.Now);
                else if (cmbPayment.SelectedItem.ToString()== "Debit")
                    paymentService.CreatePayment(CurrentPayment.PaymentID, CurrentPayment.TableNumber, CurrentPayment.EmployeeID, CurrentPayment.TotalPriceNoVAT, CurrentPayment.TotalPriceVAT,0, DateTime.Now);
            }
            else
            {
                MessageBox.Show("Please choose a payment method", "Payment method required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
