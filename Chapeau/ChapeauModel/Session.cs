using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Session
    {
        public Employee LoggedEmployee { get; private set; }

        static Session instance;
        public static Session Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        private Session()
        {
        }

        public void SetLoggedEmployee(Employee employee)
        {
            LoggedEmployee = employee;
        }

    }
}
