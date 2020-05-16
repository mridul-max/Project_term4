﻿using System;
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
        private Employee loggedEmployee;
        private TableService tableService;
        private List<Table> allTables;
        private List<PictureBox> occupiedIcons;

        private void TableView_Load(object sender, EventArgs e)
        {
            allTables = tableService.GetAllTables();
            occupiedIcons = FillPictureBoxes();
            CheckOccupancy();
            lblEmployee.Text = lblEmployee.Text + " " + loggedEmployee.Name;
            if (loggedEmployee.EmployeeType == EmployeeType.Manager)
            {
                returnToManagementToolStripMenuItem.Visible = true;
            }
        }
        public TableView(Employee loggedEmployee)
        {
            InitializeComponent();
            this.loggedEmployee = loggedEmployee;
            tableService = new TableService();
        }
        void DisplayTableForm(int index)
        {
            TableDisplay tableDisplay = new TableDisplay(allTables[index]);
            tableDisplay.ShowDialog();
            CheckOccupancy();
        }
        private void TableView_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void returnToManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerScreen managementScreen = new ManagerScreen(loggedEmployee);
            this.Hide();
            managementScreen.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Hide();
            login.ShowDialog();
        }
        //this methods are for changing occupancy picture visibilities.
        void CheckOccupancy()
        {
            for (int i = 0; i < allTables.Count; i++)
            {
                if (allTables[i].IsOccupied)
                {
                    occupiedIcons[i].Visible = true;
                   
                }
                else
                    occupiedIcons[i].Visible = false;               
            }
        }
        //This is method exist because I want to keep form load as clean as possible
        List<PictureBox> FillPictureBoxes()
        {
            return new List<PictureBox>() { pcoccupied1, pcoccupied2, pcoccupied3, pcoccupied4, pcoccupied5, pcoccupied6, pcoccupied7, pcoccupied8, pcoccupied9, pcoccupied10};
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
    }
}
