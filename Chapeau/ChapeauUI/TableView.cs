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
using ChapeauUI.Properties;

namespace ChapeauUI
{
    public partial class TableView : Form
    {   //write private.
        private TableService tableService;
        private List<Table> allTables;
        private List<PictureBox> orderIcons;
        private List<PictureBox> tableIcons;
        private List<PictureBox> timerIcons;
        private List<Bitmap> tableImages;
        private List<Bitmap> occupiedTableImages;


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
        void RefreshTableInformation() 
        {
            allTables = tableService.GetAllTables();
            for (int i = 0; i < allTables.Count; i++)
            {
                if (allTables[i].IsOccupied)
                {
                    tableIcons[i].Image = occupiedTableImages[i];
                    tableIcons[i].Height = 128;   // I had to change the height due to resolution issues.
                }
                else
                {
                    tableIcons[i].Image = tableImages[i];
                    tableIcons[i].Height = 103;  // I had to change the height due to resolution issues.
                }
                                  
            }
        }



        //This is method exist because I want to keep form load as clean as possible
        void FillPictureBoxes()
        {
            orderIcons = new List<PictureBox>() { pcOrder1, pcorder2, pcorder3, pcorder4, pcorder5, pcorder6, pcorder7, pcorder8, pcorder9, pcorder10 };
            tableIcons = new List<PictureBox>() { pcTable1, pcTable2, pcTable3, pcTable4, pcTable5, pcTable6, pcTable7, pcTable8, pcTable9, pcTable10 };
            tableImages = new List<Bitmap> { Resources.table1, Resources.table2, Resources.table3, Resources.table4, Resources.table5, Resources.table5, Resources.table6, Resources.table7, Resources.table8, Resources.table9, Resources.table10 };
            occupiedTableImages = new List<Bitmap>() { Resources.Occupy1,Resources.Occupy2,Resources.Occupy3,Resources.Occupy4,Resources.Occupy5,Resources.Occupy6,Resources.Occupy7,Resources.Occupy8,Resources.Occupy9,Resources.Occupy10};
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
