﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int TableNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public long PhoneNumber { get; set; }
        public string ReserverName { get; set; }

    }
}
