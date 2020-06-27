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
        OrderService OrderService = new OrderService();
        public KitchenBarScreen()
        {
            InitializeComponent();
        }

        private void KitchenBarScreen_Load(object sender, EventArgs e)
        {
            lblSelectInstruction.Text = "Select an Item first to mark it ready";
            lblloggedinChef.Text = lblloggedinChef.Text + " " + Session.Instance.LoggedEmployee.Name;
            SelectRole(Session.Instance.LoggedEmployee.EmployeeType);
        }
        // Three emplyees can log in for kitchen and bar
        private void SelectRole(EmployeeType role)
        {
            if (role == EmployeeType.Kitchen)
            {
                lblKitchenBar.Text = "Kitchen Screen";
                showPanel("Kitchen");
            }
            else if (role == EmployeeType.Bar)
            {
                lblKitchenBar.Text = "Bar Screen";
                showPanel("Bar");
            }
            else if (role == EmployeeType.Manager)
            {
                managementToolStripMenuItem.Visible = true;
                kitchenToolStripMenuItem.Visible = true;
                barToolStripMenuItem.Visible = true;
                // default to the kitchen screen
                lblKitchenBar.Text = "Kitchen Screen";
                showPanel("Kitchen");
            }
        }
        //This panel will show information of orderItem
        private void showPanel(string panelName, bool refresh = true)
        {
            if (refresh)
            {
                pnlKitchenBar.Show();
                pnlKitchenBar.Visible = true;
                List<OrderItem> Dishes;
                if (panelName == "Kitchen")
                {
                    Dishes = OrderService.GetAllRunningFood();
                }
                else
                {
                    Dishes = OrderService.GetAllRunningDrinks();
                }
                listViewKitchenBar.Clear();
                listViewKitchenBar.Columns.Add("Name");
                listViewKitchenBar.Columns.Add("Amount");
                listViewKitchenBar.Columns.Add("OrderTime");
                listViewKitchenBar.Columns.Add("Status");
                listViewKitchenBar.Columns.Add("Table");
                foreach (OrderItem dish in Dishes)
                {
                    //tablenumber can find by passing the orderID
                    int table = OrderService.GetOrderTable(dish.OrderID);
                    ListViewItem item = new ListViewItem(
                        new string[] {
                        dish.MenuItem.Name.ToString(),
                        dish.Amount.ToString(),
                        dish.DateTimeAdded.ToString("H:mm"),
                        dish.orderState.ToString(),
                        table.ToString(),
                        dish.MenuItem.ID.ToString()
                    });
                    item.Tag = dish;
                    listViewKitchenBar.Items.Add(item);
                }
                listViewKitchenBar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            //Bar panel to view the orderItem

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

        // Mark the checked items as ready
        private void btnReady_Click(object sender, EventArgs e)
        {
            //user need to select an item first
            if (listViewKitchenBar.CheckedItems.Count < 1)
            {
                MessageBox.Show("Please select an Item first");
                return;
            }

            //loop over all the items in the list
            if (MessageBox.Show($"Are you sure you want to Mark All the selected items as ready?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < listViewKitchenBar.Items.Count; i++)
                {
                    
                    if (listViewKitchenBar.Items[i].Checked)
                    {                 
                        //Message for reducing the mistakes for stuffs
                        OrderService.UpdateReadyItem((OrderItem)listViewKitchenBar.Items[i].Tag);
                    }

                }
                RefreshTheListView();
            }
        }
        //Refresh can help to disapear the order item 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTheListView();
        }

        private void RefreshTheListView()
        {
            SelectRole(Session.Instance.LoggedEmployee.EmployeeType);

        }
        //Manager can navigate the bar
        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblKitchenBar.Text = "Bar Screen";
            showPanel("Bar");
        }
        //Manager can navigate the kitchen
        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblKitchenBar.Text = "Kitchen Screen";
            showPanel("Kitchen");
        }
    }
}
