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
    public partial class LoginScreen : Form
    {
        private EmployeeService employeeService;

        public LoginScreen()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //if username or password textbox is empty, show a label that indicates that they need to be filled.
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                MessageBox.Show("Incorrect password or username", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Employee loggedEmployee = employeeService.GetEmployeeByCredentials(txtUsername.Text, txtPassword.Text);

                if (loggedEmployee == null)
                    MessageBox.Show("Incorrect password or username", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.Hide();

                    CheckEnumForForms(loggedEmployee);
                }
            }
        }
        //Opens a different form for each type of employee.
        private void CheckEnumForForms(Employee employee)
        {
            switch (employee.EmployeeType)
            {
                case EmployeeType.Waiter:
                    TableView tableForm = new TableView(employee);
                    tableForm.ShowDialog();
                    break;
                case EmployeeType.Manager:
                    ManagerScreen managerForm = new ManagerScreen(employee);
                    managerForm.ShowDialog();
                    break;
                default: // since it can only be kitchen or bar after manager and waiter.
                    KitchenBarScreen KitchenBarForm = new KitchenBarScreen(employee);
                    KitchenBarForm.ShowDialog();
                    break;
 
            }
        }


        private void ChPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}
