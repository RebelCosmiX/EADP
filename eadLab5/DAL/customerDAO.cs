﻿using System;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;

namespace eadLab5.DAL
{
    public class customerDAO
    {
        public customer getCustomerById(string custId)
        {
            //Get connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr2"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //Create Adapter
            //WRITE SQL Statement to retrieve all columns from Customer by customer Id using query parameter
            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Customer where");
            sqlCommand.AppendLine("custId = @paraCustId");
            //***TO Simulate system error  *****
            // change custId in where clause to custId1 or 
            // change connection string in web config to a wrong file name  

            customer obj = new customer();   // create a customer instance

            SqlConnection myConn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myConn);
            da.SelectCommand.Parameters.AddWithValue("paraCustId", custId);
            // fill dataset
            da.Fill(ds, "custTable");
            int rec_cnt = ds.Tables["custTable"].Rows.Count;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables["custTable"].Rows[0];  // Sql command returns only one record
                obj.customerId = row["custId"].ToString();
                obj.customerName = row["custName"].ToString();
                obj.customerAddress = row["custAddress"].ToString() + " Singapore " + row["custPostal"].ToString();
                obj.customerMobile = row["custMobile"].ToString();
                obj.customerHomePhone = row["custHomePhone"].ToString();
            }
            else
            {
                obj = null;
            }

            return obj;
        }

        public customer login(string user, string pass)
        {
            customer obj = new customer();   // create a customer instance

            string conString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string sql = "SELECT * from Customer WHERE custId=@Usern and custPassword=@pwd";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Usern", user);
                cmd.Parameters.AddWithValue("@pwd", pass);
                //cmd.Parameters.AddWithValue("@pwd", Sha1(Salt(pass)));

                using (SqlDataReader row = cmd.ExecuteReader())
                {
                    while (row.Read())
                    {
                        obj.customerId = row["custId"].ToString();
                        obj.customerName = row["custName"].ToString();
                        obj.customerAddress = row["custAddress"].ToString() + " Singapore " + row["custPostal"].ToString();
                        obj.customerMobile = row["custMobile"].ToString();
                        obj.customerHomePhone = row["custHomePhone"].ToString();
                    }
                    if (!row.HasRows)
                        obj = null;
                    conn.Close();
                }
                return obj;
            }

        }

    }
}