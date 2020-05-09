using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class ReservationService
    {
        ReservationDAO reservationDao = new ReservationDAO();

        public List<Reservation> GetAllReservations()
        {
            List<Reservation> reservations = reservationDao.GetAllReservations();

            return reservations;
        }
        public void CreateReservation(int tableNumber, DateTime reservationDate, long phoneNumber, string reserverName)
        {
            reservationDao.CreateReservation(tableNumber, reservationDate, phoneNumber, reserverName);
        }

    }

}
