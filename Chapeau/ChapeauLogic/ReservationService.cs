﻿using System;
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
            List<Reservation> reservations = reservationDao.GetAllReservations();

            return reservations;
        }
        public void CreateReservation(int tableNumber, string reservationDate, long phoneNumber, string reserverName)
        {
            reservationDao.CreateReservation(tableNumber, reservationDate, phoneNumber, reserverName);
        }

    }

}
