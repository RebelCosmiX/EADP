using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace eadLab4.DAL
{
    public class LoginDAO
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
        LoginObject L = new LoginObject();
        public LoginObject UserLogin(string role, string UserName)
        {

            conn.Open();
            string checkuser = "select count(*) from " + role + " where NRIC='" + UserName + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            L.User = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (L.User == 1)
            {
                conn.Open();
                string checkPasswordQuery = "select password from " + role + " where NRIC='" + UserName + "'";
                SqlCommand passCom = new SqlCommand(checkPasswordQuery, conn);
                L.password = passCom.ExecuteScalar().ToString();
            }
            conn.Close();

            return L;
        }
    }
}