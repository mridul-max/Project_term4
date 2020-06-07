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
    public partial class KitchenBarScreen : Form
    {
        
        public KitchenBarScreen()
        {
            InitializeComponent();       
        }

        private void KitchenBarScreen_Load(object sender, EventArgs e)
        {
            lblloggedinChef.Text = lblloggedinChef.Text+ " "+ Session.Instance.LoggedEmployee.Name;
            if (Session.Instance.LoggedEmployee.EmployeeType == EmployeeType.Kitchen)
            {
                lblKitchenBar.Text = "Kitchen Screen";
                showPanel("Kitchen");
            }
            else if(Session.Instance.LoggedEmployee.EmployeeType == EmployeeType.Bar)
            {
                lblKitchenBar.Text = "Bar Screen";
                showPanel("Bar");
            }
            else if(Session.Instance.LoggedEmployee.EmployeeType==EmployeeType.Manager)
            {
                managementToolStripMenuItem.Visible = true;
            }
        }
        private void showPanel(string panelName, bool refresh = true)
        {
            if (panelName == "Kitchen")
            {
                if (refresh)
                {
                    pnlKitchenBar.Show();
                    pnlKitchenBar.Visible = true;
                    OrderService orderService = new OrderService();
                    List<OrderItem> Food = orderService.GetAllRunningFood();
                    listViewKitchenBar.Clear();
                    listViewKitchenBar.Columns.Add("ItemName");
                    listViewKitchenBar.Columns.Add("ItemAmount");
                    listViewKitchenBar.Columns.Add("OrderTime");
                    listViewKitchenBar.Columns.Add("OrderStatus");
                    listViewKitchenBar.Columns.Add("TableNumber");
                    foreach (OrderItem F in Food)
                    {
                        int table = orderService.GetOrderTable(F.OrderID);
                        listViewKitchenBar.Items.Add(new ListViewItem(new string[] { F.MenuItem.Name.ToString(), F.Amount.ToString(), F.DateTimeAdded.ToString(), F.orderState.ToString(),table.ToString()}));
                      
                    }        
                    
                    listViewKitchenBar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }

            }
            if (panelName == "Bar")
            {
                if (refresh)
                {
                    pnlKitchenBar.Show();
                    pnlKitchenBar.Visible = true;
                    OrderService orderService = new OrderService();
                    List<OrderItem> Drinks = orderService.GetAllRunningDrinks();
                    listViewKitchenBar.Clear();
                    listViewKitchenBar.Columns.Add("ItemName");
                    listViewKitchenBar.Columns.Add("ItemAmount");
                    listViewKitchenBar.Columns.Add("OrderTime");
                    listViewKitchenBar.Columns.Add("OrderStatus");
                    listViewKitchenBar.Columns.Add("TableNumber");
                    foreach (OrderItem D in Drinks)
                    {
                        int table = orderService.GetOrderTable(D.OrderID);
                        listViewKitchenBar.Items.Add(new ListViewItem(new string[] { D.MenuItem.Name.ToString(), D.Amount.ToString(), D.DateTimeAdded.ToString(), D.orderState.ToString(),table.ToString()}));
                    }
                    listViewKitchenBar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }

            }
        }

        private void KitchenBarScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerScreen manager = new ManagerScreen();
            this.Hide();
            manager.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlKitchenBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if (listViewKitchenBar.CheckedItems.Count < 1)
            {
                MessageBox.Show("Please select an Item first");
            }
            else
            {

            }
        }
    }
}
