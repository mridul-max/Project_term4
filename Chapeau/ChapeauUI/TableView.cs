using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class TableView : Form
    {   // Components needed for tables.
        private TableService tableService;
        private List<Table> allTables;
        //Picture boxes and Icons I have.
        private List<PictureBox> dishIcons;
        private List<PictureBox> tableIcons;
        private List<PictureBox> warningIcons;
        private List<PictureBox> drinkIcons;
        private List<Bitmap> tableImages;
        private List<Bitmap> occupiedTableImages;
        //Components needed for orders and reservations.
        private ReservationService reservationService;
        private OrderService orderService;

        private void TableView_Load(object sender, EventArgs e)
        {
            FillPictureBoxes();
            RefreshTableInformation();
            lblEmployee.Text = lblEmployee.Text + " " + Session.Instance.LoggedEmployee.Name;
            if (Session.Instance.LoggedEmployee.EmployeeType == EmployeeType.Manager) 
            {
                //If the user is manager a special button in navbar will appear.
                returnToManagementToolStripMenuItem.Visible = true;
            }
        }
        public TableView()
        {
            InitializeComponent();
            tableService = new TableService();  
            reservationService = new ReservationService();
            orderService = new OrderService();
        }
        //For opening table display.
        void DisplayTableForm(int tableNr)
        {
            TableDisplay tableDisplay = new TableDisplay(allTables[tableNr]);
            tableDisplay.ShowDialog();
            RefreshTableInformation();
        }

        //For closing the application.
        private void TableView_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }
        //this methods is for changing occupancy picture visibilities.
        void RefreshTableInformation()
        {
            allTables = tableService.GetAllTables();
            //Instead of keep opening the database in for loop,I only receive all the unpaid orders at ones for the order items for being faster.
            List<Order> allUnpaidOrders = orderService.GetAllUnfinishedOrders();
            for (int i = 0; i < allTables.Count; i++)
            {

                if (allTables[i].IsOccupied)
                {
                    tableIcons[i].Image = occupiedTableImages[i];
                    //if restaurant has no present orders skip displaying icons and only change table icon.
                    if (allUnpaidOrders.Count != 0)
                    {
                        //Find the order of table[i] from the list acquired from database.
                        int indexofOrder = FindOrderIndexOfTable(allTables[i], allUnpaidOrders);
                        //If table has orders check status of orders to inform waiter with icons.                        
                        if (indexofOrder >= 0 && allUnpaidOrders[indexofOrder].OrderItems.Count != 0)
                        {
                            RefreshDishIcons(allUnpaidOrders[indexofOrder].OrderItems, i);
                            RefreshWarningIcons(allUnpaidOrders[indexofOrder].OrderItems, i);
                            RefreshDrinkIcons(allUnpaidOrders[indexofOrder].OrderItems, i);
                        }
                    }

                }
                else
                {
                    // If table is not occupied, then there is no need to show any icons.
                    tableIcons[i].Image = tableImages[i];
                    warningIcons[i].Visible = false;
                    dishIcons[i].Visible = false;
                    drinkIcons[i].Visible = false;
                }             
            }

        }
        //This method is for finding the right order for the table. Since it's quite hard to order it on
        //table numbers and filter the ones that doesnt have orders.
        int FindOrderIndexOfTable(Table table, List<Order> orders)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].TableNr == table.TableNumber)
                {
                    return i;
                }
            }
            //validation of -1 value is handled in line 86 [if(indexofORder>=0)]
            return -1;
        }
        //If a table has unserved dishes, an icon will appear to inform  the waiter.
        void RefreshDishIcons(List<OrderItem> orders, int index)
        {
            bool isOrderServed = true;//If there is even one unserved order bool should be false and icon should be available.
            //If all orders are served there is no need to warn the waiter.
            bool isOrderReady = true;
            foreach (OrderItem order in orders)
            {
                if (order.orderState != OrderState.OrderServed)
                {
                    if (order.MenuItem.CategoryType != CategoryType.Drinks)
                    {                
                        if(order.orderState==OrderState.ReadyToDeliver)
                        {
                            isOrderReady = false;
                        }
                        isOrderServed = false;
                        
                    }
                }

            }
            if (!isOrderServed)
            {
                if(!isOrderReady)
                {
                    dishIcons[index].BackColor = Color.Lime;
                }
                else
                {
                    dishIcons[index].BackColor = Color.Transparent;
                }
                dishIcons[index].Visible = true;
            }
            else
            {
                dishIcons[index].BackColor = Color.Transparent; // this field is required in case user changes orderstate.
                dishIcons[index].Visible = false;
            }

        }
        //If a waiter has been waiting more than ten minutes an icon will appear to inform waiter.
        void RefreshWarningIcons(List<OrderItem> orders, int index)
        {
            //If there is even one unserved order bool should be false and icon should be available if the order's been waiting for more than 10 minutes.
            bool isOrderServed = true;
            //if all orders are served, there is no need for warning icons.
            foreach (OrderItem item in orders)
            {
                if (item.orderState != OrderState.OrderServed)
                {
                    int totalseconds = (int)(DateTime.Now - item.DateTimeAdded).TotalSeconds;
                    if ((totalseconds / 60) >= 10 && item.orderState != OrderState.OrderServed)
                    {                       
                        isOrderServed = false;
                        break;
                    }
                }

            }
            if(!isOrderServed)
            {
                warningIcons[index].Visible = true;
            }
            else
            {
                warningIcons[index].Visible = false;  // this field is required in case user changes orderstate.

            }
        }
        //If a table has unserved drinks,an icon will appear to inform  the waiter.

        void RefreshDrinkIcons(List<OrderItem> orders, int index)
        {
            //If there is even one unserved order bool should be false and icon should be available.
            bool isOrderServed = true;
            bool isOrderReady = true;
            foreach (OrderItem order in orders)
            {
                //if all orders are served there is no need to  display drink icons for that table.
                if (order.orderState != OrderState.OrderServed)
                {
                    if (order.MenuItem.CategoryType == CategoryType.Drinks)
                    {
                        if (order.orderState == OrderState.ReadyToDeliver)
                        {
                            isOrderReady = false;
                        }

                        isOrderServed = false;
                      
                    }
                }
            }
            if(!isOrderServed)
            {
                if(!isOrderReady)
                {
                    drinkIcons[index].BackColor = Color.Lime;
                }
                else
                {
                    drinkIcons[index].BackColor = Color.Transparent;
                }
                drinkIcons[index].Visible = true;

            }
            else
            {
                drinkIcons[index].BackColor = Color.Transparent;
                drinkIcons[index].Visible = false; // this field is required in case user changes orderstate.
            }
        }
       

        //This is method exist because I want to keep form load as clean as possible
        void FillPictureBoxes()
        {
            dishIcons = new List<PictureBox>() { pcOrder1, pcOrder2, pcOrder3, pcOrder4, pcOrder5, pcOrder6, pcOrder7, pcOrder8, pcOrder9, pcOrder10 };
            tableIcons = new List<PictureBox>() { pcTable1, pcTable2, pcTable3, pcTable4, pcTable5, pcTable6, pcTable7, pcTable8, pcTable9, pcTable10 };
            warningIcons = new List<PictureBox>() { pcwarning1, pcwarning2, pcwarning3, pcwarning4, pcwarning5, pcwarning6, pcwarning7, pcwarning8, pcwarning9, pcwarning10 };
            drinkIcons = new List<PictureBox>() { pcDrinks1, pcDrinks2, pcDrinks3, pcDrinks4, pcDrinks5, pcDrinks6, pcDrinks7, pcDrinks8, pcDrinks9, pcDrinks10 };          
            tableImages = new List<Bitmap> { Properties.Resources.Empty1, Properties.Resources.Empty2, Properties.Resources.Empty3, Properties.Resources.Empty4, Properties.Resources.Empty5, Properties.Resources.Empty6, Properties.Resources.Empty7, Properties.Resources.Empty8, Properties.Resources.Empty9, Properties.Resources.Empty10 };
            occupiedTableImages = new List<Bitmap>() { Properties.Resources.Occupy1, Properties.Resources.Occupy2, Properties.Resources.Occupy3, Properties.Resources.Occupy4, Properties.Resources.Occupy5, Properties.Resources.Occupy6, Properties.Resources.Occupy7, Properties.Resources.Occupy8, Properties.Resources.Occupy9, Properties.Resources.Occupy10 };
        }

        //This code opens a table display form according to the sender index.

        private void pcboxtb1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender; //store the clicked table
            int tableId = int.Parse(pictureBox.Name.Remove(0, 7));
            DisplayTableForm(tableId - 1);
        }
        //for returning the login screen.
        private void logOffToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }
        //If user is a manager this is for returning to management.
        private void returnToManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManagerScreen manager = new ManagerScreen();
            this.Hide();
            manager.ShowDialog();
        }
        //Button for refreshing the page.
        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshTableInformation(); 
        }

        private void pnl_tables_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
