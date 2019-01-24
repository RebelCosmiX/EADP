using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eadLab5.DAL
{
    public class custTripDao
    {
        public List<custTrip> GetTrips(string user)
        {
            List<custTrip> trips = new List<custTrip>();

            string conString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = "SELECT custTrip.custTripId,custTrip.custId, custTrip.tripId , custTrip.states ,Trip.tripName, Trip.Id  FROM custTrip INNER JOIN Trip ON custTrip.tripId = Trip.Id WHERE custTrip.custId =@Usern AND custTrip.states='on' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Usern", user);
                
                SqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    custTrip cust = new custTrip();
                    cust.custTripId = Convert.ToInt32(row["custTripId"]);
                    cust.tripId = Convert.ToInt32(row["tripId"]);
                    cust.custId = row["custId"].ToString();
                    cust.tripName = row["tripName"].ToString();
                    cust.state = row["states"].ToString();
                    trips.Add(cust);
                }
                conn.Close();
            }

            return trips;
        }

        public void deleteTrip(string id)
        {
            string conString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = "UPDATE custTrip  SET states ='off' WHERE custTripId =@Usern ; ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Usern", id);
                SqlDataReader row = cmd.ExecuteReader();
                
                conn.Close();
            }
        }
    }
}