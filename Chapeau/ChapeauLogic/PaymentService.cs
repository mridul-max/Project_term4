using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class PaymentService
    {
        PaymentDAO paymentDao = new PaymentDAO();
        public void CreatePayment(int OrderID, int tableNumber, int EmployeeID, float TotalPriceNoVAT, float TotalPriceVAT, int PaymentMethod, DateTime PaymentDate)
        {
            paymentDao.CreatePayment(OrderID, tableNumber, EmployeeID ,TotalPriceNoVAT, TotalPriceVAT, PaymentMethod, PaymentDate);
        }
        public Payment GetById(int id)
        {
            return paymentDao.GetById(id);
        }
        public List<Payment> GetAllPayments()
        {
            return paymentDao.GetAllPayments();
        }
    }
}
