using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int TableNumber { get; set; }
        public int EmployeeID { get; set; }
        public float TotalPriceVAT{get;set;}
        public float TotalPriceNoVAT { get; set; }
        public int PaymentMethod { get; set; }  //if 1 cash if 0 debit/credit.
        public DateTime PaymentDate { get; set; }
    }
}
