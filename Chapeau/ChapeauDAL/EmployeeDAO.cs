using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using SomerenDAL;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class EmployeeDAO : Base
    {
        public EmployeeDAO() : base() { }


        // Returns all drinks into a list from database.
        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT [EmployeeID],[EmployeeTypeKey],[Name],[Username],[Password] FROM employee;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeID = (int)dr["EmployeeID"],
                    EmployeeType = ConvertToEnum((string)dr["EmployeeTypeKey"]),
                    Name = (string)dr["Name"],
                    Username = (string)dr["Username"],
                    Password = (string)dr["Password"]
                };
                employees.Add(employee);
            }
            return employees;
        }
        //Gets an employee with a requested Id.
        public Employee GetById(int id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT [EmployeeID],[EmployeeTypeKey],[Name],[Username],[Password] FROM employee WHERE EmployeeID = @Id;", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;

            if (reader.Read())
                employee = ReadEmployee(reader);

            reader.Close();
            conn.Close();
            return employee;
        }
        public Employee GetEmployeeByCredentials(string username, string password)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT EmployeeID,EmployeeTypeKey,[Name],Username,[Password] FROM Employee WHERE Username= @Username  AND [password]=@Password COLLATE Latin1_General_CS_AS; ", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;

            if (reader.Read())
                employee = ReadEmployee(reader);

            reader.Close();
            conn.Close();
            return employee;
        }
        //for getbyid method.
        private Employee ReadEmployee(SqlDataReader reader)
        {
            Employee employee = new Employee()
            {
                EmployeeID = (int)reader["EmployeeID"],
                EmployeeType = ConvertToEnum((string)reader["EmployeeTypeKey"]),
                Name = (string)reader["Name"],
                Username = (string)reader["Username"],
                Password = (string)reader["Password"]
            };
            return employee;
        }

        public void RemoveEmployee(Employee employee, bool Ismanager)
        {
            if (Ismanager)//We have this because in order to enter a new employee to the db you have to be a manager.
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmployeeID =@Id;", conn);
                cmd.Parameters.AddWithValue("@Id", employee.EmployeeID);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                conn.Close();
            }
        }
        public void CreateEmployee(bool isManager,Employee employee) // think about a better solution than isManager.
        {
            //We validate this because only a manager can create accounts for employees.
            if (isManager)
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(" INSERT INTO Employee VALUES('@employeeTypeKey', '@name', '@username', '@password');", conn);
                cmd.Parameters.AddWithValue("@employeeTypeKey", employee.EmployeeType);
                cmd.Parameters.AddWithValue("@name", employee.Name);
                cmd.Parameters.AddWithValue("@username", employee.Username);
                cmd.Parameters.AddWithValue("@password", employee.Password);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                conn.Close();
            }

        }
        private EmployeeType ConvertToEnum(string employeetype)
        {
            switch (employeetype)
            {
                case "MN":
                    return EmployeeType.Manager;

                case "BR":
                    return EmployeeType.Bar;
                case "KC":
                    return EmployeeType.Kitchen;
                case "WA":
                    return EmployeeType.Waiter;
                default:
                    return EmployeeType.Waiter;
            }
        }


    }
}
