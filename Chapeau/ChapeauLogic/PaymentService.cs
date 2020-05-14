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
        public void CompletePayment(Payment payment)
        {
            try
            {
                paymentDao.CompletePayment(payment);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't finish  the payment";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
            
        }
        public Payment GetById(int id)
        {
            try
            {
                return paymentDao.GetById(id);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't get  the payment";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
           
        }
        public List<Payment> GetAllPayments()
        {
            try
            {
                return paymentDao.GetAllPayments();
            }
            catch
            {
                string errorstr = "Chapeau App couldn't get the payments";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
            
        }
    }
}
