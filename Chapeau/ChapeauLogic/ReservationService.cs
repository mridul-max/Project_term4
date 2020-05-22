using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    //class for communication with dao and ui layer.
    public class ReservationService
    {
        ReservationDAO reservationDao = new ReservationDAO();

        public List<Reservation> GetAllReservations()
        {

            try
            {
                return reservationDao.GetAllReservations();
            }
            catch 
            {
                string errorstr = "Chapeau App couldn't get the reservations";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }



        }
        public List<Reservation> GetAllById(int TableNr)
        {
          return  reservationDao.GetAllById(TableNr);
        }
        public void CreateReservation(int tableNumber, string reservationDate, long phoneNumber, string reserverName)
        {
            try
            {
                reservationDao.CreateReservation(tableNumber, reservationDate, phoneNumber, reserverName);
            }
            catch 
            {
                string errorstr = "Chapeau App couldn't create the reservation";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }

        }

    }

}
