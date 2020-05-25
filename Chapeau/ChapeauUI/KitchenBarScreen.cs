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
                showPanel("pnlKitchen");
            }
            else if(Employee.LoggedEmployee.EmployeeType == EmployeeType.Bar)
            { 
                showPanel("pnlBarScreen");
            }
        }
        private void showPanel(string panelName,bool refresh = true)
        {
            if (panelName == "pnlKitchen")
            {
                if (refresh)
                {
                    pnlBarScreen.Hide();
                    pnlKitchen.Show();
                    pnlKitchen.Visible = true;
                    lblKitchenScreen.Text = "Kitchen Screen";
                    OrderService orderService = new OrderService();
                    List<OrderItem> Food = orderService.GetListOfFood();
                    ListViewKitchen.Clear();
                    ListViewKitchen.Columns.Add("FName");
                    ListViewKitchen.Columns.Add("FAmount");
                    ListViewKitchen.Columns.Add("FOrderDTime");
                    ListViewKitchen.Columns.Add("FOrderStatus");
                    foreach (OrderItem F in Food)
                    {
                        ListViewKitchen.Items.Add(new ListViewItem(new string[] { F.MenuItem.Name.ToString(), F.Amount.ToString(), F.DateTimeAdded.ToString(), F.orderState.ToString() }));
                    }
                    listViewBar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                }
           
            }
            else if (panelName == "pnlBarScreen")
            {

                if (refresh)
                {
                    pnlKitchen.Hide();
                    pnlBarScreen.Show();
                    pnlBarScreen.Visible = true;
                    lblKitchenScreen.Text = "Bar Screen";
                    OrderService orderService = new OrderService();
                    List<OrderItem> Drinks = orderService.GetAllDrinks();
                    listViewBar.Clear();
                    listViewBar.Columns.Add("DrinkName");
                    listViewBar.Columns.Add("DrinkAmount");
                    listViewBar.Columns.Add("DrinkOrderTime");
                    listViewBar.Columns.Add("DrinkStatus");
                    listViewBar.Columns.Add("DTableNumber");
                    foreach (OrderItem O in Drinks)
                    {
                        listViewBar.Items.Add(new ListViewItem(new string[] { O.MenuItem.Name.ToString(), O.Amount.ToString(), O.DateTimeAdded.ToString(), O.orderState.ToString()}));
                    }
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
    }
}
