using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAdd.Show();
            pnlEditEmp.Hide();
            pnlRemove.Hide();
            cmbEmpType.Items.Clear();
            string[] employeeTypes = new string[] { "Manager", "Waiter", "Kitchen", "Bar" };
            cmbEmpType.Items.AddRange(employeeTypes);

        }

        private void ReturnToManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerScreen manager = new ManagerScreen();
            this.Hide();
            manager.ShowDialog();
        }

        private void BtnEmpApply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 4 || String.IsNullOrEmpty(txtUsername.Text) || cmbEmpType.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill the required fields properly!!", "Insufficient/Incorrect information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee employee = service.VerifyUsername(txtUsername.Text);
            if (employee != null)
            {
                MessageBox.Show("This username is already taken, please chose a different one", "Insufficient/Incorrect information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            employee = new Employee();
            employee.Name = txtName.Text;
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

            service.CreateEmployee(employee);
            MessageBox.Show("Employee has been created", "Process successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbEmpType.SelectedItem = null;
        }

        private void EditEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //For edit employee button in navbar.
            FillEmployeeListView(listEditEmployee);
            pnlEditEmp.Show();
            pnlAdd.Hide();
            pnlRemove.Hide();
        }

        private void BtnApplyEdit_Click(object sender, EventArgs e)
        {
            if (listEditEmployee.SelectedItems.Count < 1)
                return;

            if (String.IsNullOrEmpty(txtEditUser.Text))
            {
                MessageBox.Show("The username can not be empty!", "Insufficient/Incorrect information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee ChosenEmployee = (Employee)listEditEmployee.SelectedItems[0].Tag;            

            if (!String.IsNullOrEmpty(txtEditPassword.Text))
            {
                ChosenEmployee.Password = txtEditPassword.Text;
            }
            ChosenEmployee.Username = txtEditUser.Text;
            service.UpdateEmployee(ChosenEmployee);
            txtEditUser.Text = "";
            txtEditPassword.Text = "";
            MessageBox.Show("Employee has been updated", "Employee Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillEmployeeListView(listEditEmployee);
        }

        private void RemoveEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide other panels and show remove panel.
            pnlAdd.Hide();
            pnlEditEmp.Hide();
            FillEmployeeListView(listRemoveEmployee);
            pnlRemove.Show();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //If user picked an employee delete it.
            if (listRemoveEmployee.SelectedItems[0] == null)
            {
                Console.WriteLine("Please pick an employee to remove from system.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //get's the id from combo box by splitting it.
                Employee ChosenEmployee = (Employee)listRemoveEmployee.SelectedItems[0].Tag;

                if (MessageBox.Show($"Are you sure you want to delete {ChosenEmployee.Name} ", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.RemoveEmployee(ChosenEmployee);                    
                    MessageBox.Show("Employee has been removed.", "Employee removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillEmployeeListView(listRemoveEmployee);
                }
            }
        }

        private void FillEmployeeListView(ListView listView)
        {
            List<Employee> employees = service.GetAllEmployees();

            listView.Clear();
            listView.Columns.Add("ID");
            listView.Columns.Add("Name");
            listView.Columns.Add("Type");
            listView.Columns.Add("Username");
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem(
                    new string[] {
                    employee.EmployeeID.ToString(),
                    employee.Name,
                    employee.EmployeeType.ToString(),
                    employee.Username
                });
                item.Tag = employee;
                listView.Items.Add(item);

            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listEditEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEditEmployee.SelectedItems.Count > 0)
            {
                Employee SelectedEmployee = (Employee)listEditEmployee.SelectedItems[0].Tag;
                txtEditUser.Text = SelectedEmployee.Username;
                txtEditPassword.Text = "";
            }
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            EditEmployeeToolStripMenuItem_Click(sender, e);
        }
    }
}
