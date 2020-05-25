using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public EmployeeType EmployeeType {get;set;}
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
