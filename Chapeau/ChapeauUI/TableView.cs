using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<PictureBox> reservationIcons;
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
        void DisplayTableForm(int index)
        {
            TableDisplay tableDisplay = new TableDisplay(allTables[index]);
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
            List<Order> allUnpaidOrders = orderService.GetAllUnfinishedOrders(); //Instead of keep opening the database in for loop now I only receive all the unpaid orders at ones for the order items.
            for (int i = 0; i < allTables.Count; i++)
            {
               
                if (allTables[i].IsOccupied)
                {
                    tableIcons[i].Image = occupiedTableImages[i];
                    int indexofOrder = OrderIndexOfTable(allTables[i], allUnpaidOrders);
                    //If table has orders check status of orders to inform waiter with icons.
                    if (allUnpaidOrders[indexofOrder].OrderItems.Count>0)
                    {
                        RefreshDishIcons(allUnpaidOrders[indexofOrder].OrderItems, i);
                        RefreshWarningIcons(allUnpaidOrders[indexofOrder].OrderItems, i);
                        RefreshDrinkIcons(allUnpaidOrders[indexofOrder].OrderItems, i);
                    }                  
                }
                else
                {
                    // If table is not occupied there is no need to show any icons.
                    tableIcons[i].Image = tableImages[i];
                    warningIcons[i].Visible = false;
                    dishIcons[i].Visible = false;
                    drinkIcons[i].Visible = false;
                }
                List<Reservation> reservations = reservationService.GetAllById(allTables[i].TableNumber);
                if (reservations.Count > 0)
                {
                    RefreshReservationIcons(reservations, i);
                }
            }

        }
        //This method is for finding the right order for the table.
        int OrderIndexOfTable(Table table,List<Order>orders)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if(orders[i].TableNr==table.TableNumber)
                {
                    return i;
                }
            }
            //Since this will only be checked when the table is occupied it will always return the right value therefore it will never reach line 111.
            return 0;
        }
        //If a table has unserved dishes, an icon will appear to inform  the waiter.
        void RefreshDishIcons(List<OrderItem> orders, int index)
        {
            
            foreach (OrderItem order in orders)
            {
                if (order.MenuItem.CategoryType != CategoryType.Drinks)
                {
                    dishIcons[index].Visible = true;
                    break;
                }
            }

        }
        //If a waiter has been waiting more than ten minutes an icon will appear to inform waiter.
        void RefreshWarningIcons(List<OrderItem> orders, int index)
        {

            foreach (OrderItem item in orders)
            {
                int totalseconds = (int)(DateTime.Now - item.DateTimeAdded).TotalSeconds;
                if ((totalseconds / 60) >= 10 && item.orderState != OrderState.ReadyToDeliver)
                {
                    warningIcons[index].Visible = true;
                    break;
                }

            }
        }
        //If a table has unserved drinks,an icon will appear to inform  the waiter.

        void RefreshDrinkIcons(List<OrderItem> orders, int index)
        {
            foreach (OrderItem order in orders)
            {
                if (order.MenuItem.CategoryType == CategoryType.Drinks)
                {
                    drinkIcons[index].Visible = true;
                    break;
                }
            }
        }

        //If a table has a reservation in the next hour an icon will appear to inform waiter.
        void RefreshReservationIcons(List<Reservation>reservations, int index)
        {         
            foreach (Reservation reservation in reservations)
            {
                //Only check if table has a reservation today.
                if(DateTime.Now.Date==reservation.ReservationDate.Date)
                {
                    int totalMinutes = (int)(DateTime.Now - reservation.ReservationDate).TotalMinutes;
                    if (totalMinutes <= 60)
                    {
                        reservationIcons[index].Visible = true;
                        break;
                    }
                }
               
            }
        }

        //This is method exist because I want to keep form load as clean as possible
        void FillPictureBoxes()
        {
            dishIcons = new List<PictureBox>() { pcOrder1, pcOrder2, pcOrder3, pcOrder4, pcOrder5, pcOrder6, pcOrder7, pcOrder8, pcOrder9, pcOrder10 };
            tableIcons = new List<PictureBox>() { pcTable1, pcTable2, pcTable3, pcTable4, pcTable5, pcTable6, pcTable7, pcTable8, pcTable9, pcTable10 };
            warningIcons = new List<PictureBox>() { pcwarning1, pcwarning2, pcwarning3, pcwarning4, pcwarning5, pcwarning6, pcwarning7, pcwarning8, pcwarning9, pcwarning10 };
            drinkIcons = new List<PictureBox>() { pcDrinks1, pcDrinks2, pcDrinks3, pcDrinks4, pcDrinks5, pcDrinks6, pcDrinks7, pcDrinks8, pcDrinks9, pcDrinks10 };
            reservationIcons = new List<PictureBox>() { pcReserve1, pcReserve2, pcReserve3, pcReserve4, pcReserve5, pcReserve6, pcReserve7, pcReserve8, pcReserve9, pcReserve10 };
            tableImages = new List<Bitmap> { Properties.Resources.Empty1, Properties.Resources.Empty2, Properties.Resources.Empty3, Properties.Resources.Empty4, Properties.Resources.Empty5, Properties.Resources.Empty6, Properties.Resources.Empty7, Properties.Resources.Empty8, Properties.Resources.Empty9, Properties.Resources.Empty10 };
            occupiedTableImages = new List<Bitmap>() { Properties.Resources.Occupy1, Properties.Resources.Occupy2, Properties.Resources.Occupy3, Properties.Resources.Occupy4, Properties.Resources.Occupy5, Properties.Resources.Occupy6, Properties.Resources.Occupy7, Properties.Resources.Occupy8, Properties.Resources.Occupy9, Properties.Resources.Occupy10 };
        }

        //in this code between region picture box codes are implemented.
        #region Display table code for picture boxes.
        private void pcboxtb1_Click(object sender, EventArgs e)
        {
            DisplayTableForm(0);
        }

        private void pcboxtb2_Click(object sender, EventArgs e)
        {
            DisplayTableForm(1);
        }

        private void pcboxtb3_Click(object sender, EventArgs e)
        {
            DisplayTableForm(2);
        }

        private void pcboxtb4_Click(object sender, EventArgs e)
        {
            DisplayTableForm(3);
        }

        private void pcboxtb5_Click(object sender, EventArgs e)
        {
            DisplayTableForm(4);
        }

        private void pcboxtb6_Click(object sender, EventArgs e)
        {
            DisplayTableForm(5);
        }

        private void pcboxtb7_Click(object sender, EventArgs e)
        {
            DisplayTableForm(6);
        }

        private void pcboxtb8_Click(object sender, EventArgs e)
        {
            DisplayTableForm(7);
        }

        private void pcboxtb9_Click(object sender, EventArgs e)
        {
            DisplayTableForm(8);
        }

        private void pcboxtb10_Click(object sender, EventArgs e)
        {
            DisplayTableForm(9);
        }
        #endregion


        //for returning the login screen.
        private void logOffToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }

        private void returnToManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManagerScreen manager = new ManagerScreen();
            this.Hide();
            manager.ShowDialog();
        }
    }
}
