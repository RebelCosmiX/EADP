using System;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;

namespace eadLab4.DAL
{
    public class tripdetailsDAO
    {
        public tripdetails getTripByCode(string code)
        {
            // Get connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            // Create Adapter
            // Write SQL statement to retreive all columns from tripdetails by trip code using query parameter
            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Trips where");
            sqlCommand.AppendLine("tripCode = @paraCode");
            // *** To simulate system error ***
            // change code in where clause to code1 or
            // change connection string in web config to a wrong file name

            tripdetails obj = new tripdetails(); // create a tripdetails instance

            SqlConnection myConn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myConn);
            da.SelectCommand.Parameters.AddWithValue("paraCode", code);

            // fill dataset
            da.Fill(ds, "tripTable");
            int rec_cnt = ds.Tables["tripTable"].Rows.Count;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables["tripTable"].Rows[0]; // Sql command returns only one record
                obj.code = row["tripCode"].ToString();
                obj.location = row["tripLocation"].ToString();
                obj.type = row["tripType"].ToString();
                obj.duration = row["tripDuration"].ToString();
                obj.cost = row["tripCost"].ToString();
            }
            else
            {
                obj = null;
            }

            return obj;
        }  
    }
}