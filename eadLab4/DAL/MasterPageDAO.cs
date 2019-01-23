using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace eadLab4.DAL
{
    public class MasterPageDAO
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);

        public string getName(string NRIC, string role)
        {
            conn.Open();
            string query = "SELECT Name FROM " + role + "WHERE NRIC='" + NRIC + "'";
            SqlCommand com = new SqlCommand(query, conn);
            string Name = com.ExecuteScalar().ToString();
            return Name;
        }
    }
}