using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using SomerenDAL;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class ReservationDAO : Base
    {
        public ReservationDAO() : base() { }

        //class for communication with the database.
        // Returns all drinks into a list from database.
        public List<Reservation> GetAllReservations()
        {
            string query = "SELECT ReservationID,TableNumber,ReservationDate,PhoneNumber,ReserverName FROM Reservation;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        // For getting a specific reservation.
        public List<Reservation> GetAllById(int TableNr)
        {
            string query = "select ReservationID,TableNumber,ReservationDate,PhoneNumber,ReserverName from reservation WHERE TableNumber= @Id AND ReservationDate> @Date;";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@Id",TableNr),
                new SqlParameter("@Date",DateTime.Now)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //For reading the tables.
        private List<Reservation> ReadTables(DataTable dataTable)
        {
            List<Reservation> reservations = new List<Reservation>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Reservation reservation = new Reservation()
                {
                    ReservationID = (int)dr["ReservationID"],
                    TableNumber = (int)dr["TableNumber"],
                    ReservationDate = (DateTime)dr["ReservationDate"],
                    PhoneNumber = long.Parse((string)dr["PhoneNumber"]), 
                    ReserverName = (string)dr["ReserverName"]
                };
                reservations.Add(reservation);
            }
            return reservations;
        }
        //For creating reservations.
        public void CreateReservation(int tableNumber,string reservationDate,long phoneNumber,string reserverName)
        {
            string query = "INSERT INTO Reservation VALUES(@TableNumber, @ReservationDate, @PhoneNumber, @ReserverName);";
            SqlParameter[] parameters = new SqlParameter[4]
            {
                new SqlParameter("@TableNumber", tableNumber),
                new SqlParameter("@ReservationDate", reservationDate),
                new SqlParameter("@PhoneNumber", phoneNumber.ToString()),
                new SqlParameter("@ReserverName", reserverName)
            };
            ExecuteEditQuery(query,parameters);                                   
        }

        //For reading a singular reservation.
        private Reservation ReadReservation(SqlDataReader reader)
        {
            Reservation reservation = new Reservation()
            {
                ReservationID = (int)reader["ReservationID"],
                TableNumber = (int)reader["TableNumber"],
                ReservationDate = (DateTime)reader["ReservationDate"],
                PhoneNumber = long.Parse((string)reader["PhoneNumber"]),
                ReserverName = (string)reader["ReserverName"]
            };
            return reservation;
        }


    }
}
