﻿using ChapeauDAL;
using ChapeauLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ChapeauUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[]args)
        {
            //OrderService s = new OrderService();
            //int d = s.GetOrderTable(107);
            //MessageBox.Show(d.ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());

        }
    }
}
