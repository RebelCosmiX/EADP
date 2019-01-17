using System;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;

namespace eadLab5.DAL
{
    public class tripdetailsDAO
    {
        public tripdetails getTripByTripCode(string tripCode)
        {
            //Get connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //Create Adapter
            //WRITE SQL Statement to retrieve all columns from Trips by tripCode using query parameter
            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Trips where");
            sqlCommand.AppendLine("tripCode = @paraTripCode");
            //***TO Simulate system error  *****

            tripdetails obj = new tripdetails();   // create a tripdetails instance

            SqlConnection myConn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myConn);
            da.SelectCommand.Parameters.AddWithValue("paraTripCode", tripCode);
            // fill dataset
            da.Fill(ds, "tripsTable");
            int rec_cnt = ds.Tables["tripsTable"].Rows.Count;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables["tripsTable"].Rows[0];  // Sql command returns only one record
                obj.tripCode = row["tripCode"].ToString();
                obj.tripName = row["tripName"].ToString();
                obj.tripType = row["tripType"].ToString();
                obj.tripCost = row["tripCost"].ToString();
                obj.tripDuration = row["tripDuration"].ToString();
            }
            else
            {
                obj = null;
            }

            return obj;
        }
    }
}