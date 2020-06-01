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
    public partial class EditEmployee : Form
    {
        EmployeeService service = new EmployeeService();
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdd.Show();
            pnlEditEmp.Hide();
            string[] employeeTypes = new string[] { "Manager", "Waiter", "Kitchen", "Bar" };
            cmbEmpType.Items.AddRange(employeeTypes);

        }

        private void returnToManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerScreen manager = new ManagerScreen();
            this.Hide();
            manager.ShowDialog();
        }

        private void btnEmpApply_Click(object sender, EventArgs e)
        {
            bool IsError = false; // IF false add if true don't add employee.

            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                IsError = true;
            }
            if (String.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 4)
            {
                IsError = true;
            }

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                IsError = true;
            }
            else
            {
                Employee employee = service.VerifyUsername(txtUsername.Text);
                if (employee != null)
                {
                    IsError = true;
                }
            }

            if (cmbEmpType.SelectedIndex < 0)
            {
                IsError = true;
            }


            if (IsError == false)
            {
                Employee employee = new Employee();
                employee.Username = txtUsername.Text;
                employee.Password = txtPassword.Text;

                //"Manager", "Waiter", "Kitchen", "Bar" 
                switch (cmbEmpType.SelectedItem)
                {
                    case "Manager":
                        employee.EmployeeType = EmployeeType.Manager;
                        break;
                    case "Kitchen":
                        employee.EmployeeType = EmployeeType.Kitchen;
                        break;
                    case "Bar":
                        employee.EmployeeType = EmployeeType.Bar;
                        break;
                    default:
                        employee.EmployeeType = EmployeeType.Waiter;
                        break;
                }
                employee.Name = txtName.Text;

                service.CreateEmployee(employee);

            }
            else
            {
                MessageBox.Show("Please fill the required fields properly!!", "Insufficient/Incorrect information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void EditEmployee_Load(object sender, EventArgs e)
        {


        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEditEmp.Show();
            pnlAdd.Hide();
            cmbAllEmp.Items.Clear();
            List<Employee> employees = service.GetAllEmployees();
            foreach (Employee employee in employees)
            {
                cmbAllEmp.Items.Add(employee.EmployeeID + ":" + employee.Name);
            }
        }

        private void btnApplyEdit_Click(object sender, EventArgs e)
        {
            bool IsError = false;
            Employee EditedEmployee = new Employee();
            if (cmbAllEmp.SelectedIndex < 0)
            {
                IsError = true;
            }
            string selectedItem = cmbAllEmp.SelectedItem.ToString();
            string[] empId = selectedItem.Split(':');
            Employee ChosenEmployee = service.GetById(int.Parse(empId[0]));
            EditedEmployee.EmployeeID = ChosenEmployee.EmployeeID;
            if (String.IsNullOrEmpty(txtEditUser.Text))
            {
                //If it's empty fill the old username.
                EditedEmployee.Username = ChosenEmployee.Username;
                MessageBox.Show(EditedEmployee.Username + " Line 141");
            }
            else
            {
                //Verifying whether there are anyone with this username in the database.
                Employee employee = service.VerifyUsername(txtEditUser.Text);
                if (employee != null)
                {
                    IsError = true;
                }
                else
                {
                    EditedEmployee.Username = txtEditUser.Text;
                }
            }

            if (String.IsNullOrEmpty(txtEditPassword.Text))
            {
                //If it's empty fill the old password.
                EditedEmployee.Password = ChosenEmployee.Password;
            }
            else if (txtEditPassword.Text.Length > 4 && txtEditPassword.Text.Length <14)
            {
                EditedEmployee.Password = txtEditPassword.Text;
               
            }
            else
            {
                IsError = true;
            }



            if (IsError == false)
            {
                service.UpdateEmployee(EditedEmployee);
                MessageBox.Show("Employee has been updated", "Employee Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill the fields properly", "Employee could not updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
