using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eadLab5.DAL
{
    public class tripDao
    {
        public List<Trip> GetTrips()
        {
           List<Trip> trips = new List<Trip>();

        string conString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = "Select * FROM Trip";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                SqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    Trip trip = new Trip();
                    trip.id = row["id"].ToString();
                    trip.tripName = row["tripName"].ToString();
                    trip.tripDescription = row["tripDescription"].ToString();
                    trip.tripCountry = row["tripCountry"].ToString();
                    trip.lat = row["lat"].ToString();
                    trip.lng = row["lng"].ToString();

                    trips.Add(trip);
                }
                conn.Close();
            }

            return trips;
        }

    }
}