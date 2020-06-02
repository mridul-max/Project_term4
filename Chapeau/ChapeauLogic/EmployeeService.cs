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

        public void CreateEmployee(Employee employee)
        {
            try
            {
                employeeDao.CreateEmployee(employee);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't create the employee account";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
           
        }
        public void UpdateEmployee(Employee employee)
        {
            try
            {
                employeeDao.UpdateEmployee(employee);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't update the employee account";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
        }
        public Employee VerifyUsername(string username)
        {
            return employeeDao.VerifyUsername(username);
        }
        public void RemoveEmployee(Employee employee)
        {
            try
            {
                employeeDao.RemoveEmployee(employee);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't remove the employee account";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
           
        }
        public Employee GetById(int id)
        {
            try
            {
                return employeeDao.GetById(id);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't get the employee account";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
                 
        }
        public List<Employee> GetAllEmployees()
        {
            try
            {
                return employeeDao.GetAllEmployees();
            }
            catch
            {
                string errorstr = "Chapeau App couldn't return the employees";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
                 
        }

        public Employee GetEmployeeByCredentials(string username, string password)
        {
            try
            {
                return employeeDao.GetEmployeeByCredentials(username, password);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't return the employee with these credentials";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
            
        }

    }
}
