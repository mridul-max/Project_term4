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
    {   //write private.
        private TableService tableService;
        private List<Table> allTables;
        private List<PictureBox> orderIcons;
        private List<PictureBox> tableIcons;
        private List<PictureBox> warningIcons;
        private List<Bitmap> tableImages;
        private List<Bitmap> occupiedTableImages;
        private ReservationService reservationService;
        private OrderService orderService;

        private void TableView_Load(object sender, EventArgs e)
        {
            FillPictureBoxes();
            RefreshTableInformation();
            lblEmployee.Text = lblEmployee.Text + " " + Employee.LoggedEmployee.Name;
            if (Employee.LoggedEmployee.EmployeeType == EmployeeType.Manager)
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
        //this methods are for changing occupancy picture visibilities.
        void RefreshTableInformation() // ask about this [refresh]
        {
            allTables = tableService.GetAllTables();
            for (int i = 0; i < allTables.Count; i++)
            {
                if (allTables[i].IsOccupied)
                {
                    tableIcons[i].Image = occupiedTableImages[i];
                    List<OrderItem> items = orderService.GetUnfinishedOrdersOfTable(allTables[i].TableNumber);
                    if (items.Count > 0)
                    {
                        orderIcons[i].Visible = true;
                    }
                    else
                    {
                        orderIcons[i].Visible = false;
                    }
                    //Change this ui code it's slow.

                    foreach (OrderItem item in items)
                    {

                        int totalseconds = (int)(DateTime.Now - item.DateTimeAdded).TotalSeconds;
                        if ((totalseconds / 60) >= 10 && item.orderState != OrderState.ReadyToDeliver)
                        {
                            warningIcons[i].Visible = true;
                        }
                        else
                        {
                            warningIcons[i].Visible = false;
                        }
                    }
                }
                else
                {
                    tableIcons[i].Image = tableImages[i];
                    warningIcons[i].Visible = false;
                    orderIcons[i].Visible = false;
                }                                     
            }

        }

        //This is method exist because I want to keep form load as clean as possible
        void FillPictureBoxes()
        {
            orderIcons = new List<PictureBox>() { pcOrder1, pcOrder2, pcOrder3, pcOrder4, pcOrder5, pcOrder6, pcOrder7, pcOrder8, pcOrder9, pcOrder10 };
            tableIcons = new List<PictureBox>() { pcTable1, pcTable2, pcTable3, pcTable4, pcTable5, pcTable6, pcTable7, pcTable8, pcTable9, pcTable10 };
            warningIcons = new List<PictureBox>() { pcwarning1, pcwarning2, pcwarning3, pcwarning4, pcwarning5, pcwarning6, pcwarning7, pcwarning8, pcwarning9, pcwarning10 };
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
