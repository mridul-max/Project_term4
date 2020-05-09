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
        EmployeeService employeeService;
        Employee loggedEmployee;//will be generated and passed in as a parameter for chapeau app after login button is clicked.
        ChapeauApp applicationForm;// this will be assigned when user successfully logs in and opens itself
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
            List<Employee> allEmployees = employeeService.GetAllEmployees();
            loggedEmployee = null;//it is null until user enter correct credentials.
            //if username or password textbox is empty, show a messagebox that indicates that they need to be filled.
            if (txtUsername.Text == null)
                MessageBox.Show("Username section needs to be properly filled!!", "Missing credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtPassword.Text == null)
                MessageBox.Show("Password section needs to be properly filled!!", "Missing credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                foreach (Employee employee in allEmployees)
                {
                    if (employee.Username == txtUsername.Text)
                    {
                        if (employee.Password == txtPassword.Text)
                        {
                            //if password and username is the same then assign this employee as new employee and stop the loop.
                            loggedEmployee = employee;
                            break;
                        }
                    }
                }
            }

            if (loggedEmployee == null)
                MessageBox.Show("Wrong username or password", "Incorrect credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //hides the login form to keep things clean.
                this.Hide();
                applicationForm = new ChapeauApp(loggedEmployee);

            }



        }
    }
}
