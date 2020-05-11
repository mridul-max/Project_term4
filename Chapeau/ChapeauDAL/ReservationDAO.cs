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
        public void CreateReservation(int tableNumber,string reservationDate,long phoneNumber,string reserverName)
        {
            //We validate this because only a manager can create accounts for employees.                       
                OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservation VALUES(@TableNumber, @ReservationDate, @PhoneNumber, @ReserverName); ", conn);
                cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber.ToString());
                cmd.Parameters.AddWithValue("@ReserverName", reserverName);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                conn.Close();            
        }


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
