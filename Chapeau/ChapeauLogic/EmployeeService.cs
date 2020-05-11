using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDAO employeeDao = new EmployeeDAO();

        public void CreateEmployee(bool isManager, string employeeTypeKey, string name, string username, string password)
        {
            employeeDao.CreateEmployee(isManager, employeeTypeKey, name, username, password);
        }
        public void RemoveEmployee(Employee employee, bool Ismanager)
        {
            employeeDao.RemoveEmployee(employee, Ismanager);
        }
        public Employee GetById(int id)
        {
            return employeeDao.GetById(id);        
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDao.GetAllEmployees();         
        }

        public Employee GetEmployeeByCredentials(string username, string password)
        {
            return employeeDao.GetEmployeeByCredentials(username,password);
        }

    }
}
