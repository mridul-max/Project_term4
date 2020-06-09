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
        // For manager part : For checking if there is someone with this username in the database.
        public Employee VerifyUsername(string username)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT [Name],EmployeeID,EmployeeTypeKey,Username,[Password] FROM Employee WHERE Username=@Username;", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;

            if (reader.Read())
                employee = ReadEmployee(reader);

            reader.Close();
            conn.Close();
            return employee;
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
        // Verifying the credentials from the database for login.
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

        //For deleting the employee.
        public void RemoveEmployee(Employee employee)
        {
            string query = "DELETE FROM Employee WHERE EmployeeID =@Id;";
            SqlParameter[] parameters = new SqlParameter[1]
            {
                new SqlParameter("@Id", employee.EmployeeID),
            };
            ExecuteEditQuery(query, parameters);
        }
        //For creating the employee.
        public void CreateEmployee(Employee employee)
        {
            //We validate this because only a manager can create accounts for employees.
            string EmployeeTypeKey = ConvertToString(employee.EmployeeType);
            string query = "INSERT INTO Employee VALUES(@employeeTypeKey, @name, @username, @password);";
            SqlParameter[] parameters = new SqlParameter[4]
            {
                new SqlParameter("@employeeTypeKey", EmployeeTypeKey),
                new SqlParameter("@name", employee.Name),
                new SqlParameter("@username", employee.Username),
                new SqlParameter("@password", employee.Password)
            };
            ExecuteEditQuery(query, parameters);
        }

        //For changing the credentials of the chosen employee.
        public void UpdateEmployee(Employee employee)
        {
            string query = "Update Employee SET Username=@Username,[Password]=@Password WHERE EmployeeID=@Id;";
            SqlParameter[] parameters = new SqlParameter[3]
            {
                new SqlParameter("@Username", employee.Username),
                new SqlParameter("@Password", employee.Password),
                new SqlParameter("@Id", employee.EmployeeID)
            };
            ExecuteEditQuery(query, parameters);
        }
        //Needed function for read employee methods. (Database has strange employee keys)
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
        // Needed function for create employee method.
        private string ConvertToString(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Manager:
                    return "MN";
                case EmployeeType.Kitchen:
                    return "KC";
                case EmployeeType.Bar:
                    return "BR";
                default:
                    return "WA"; //if none of them were correct. It could be only waiter.
            }
        }


    }
}
