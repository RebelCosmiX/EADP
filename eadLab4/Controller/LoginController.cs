using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eadLab4.DAL;
using System.Text;

namespace eadLab4.Controller
{
    public class LoginController
    {
        LoginDAO LoginOBJ = new LoginDAO();

        public string ErrMsg(string role, string username, string password)
        {
            StringBuilder sb = new StringBuilder();
            LoginObject L = new LoginObject();
            L = LoginOBJ.UserLogin(role, username);
            if (L.User != 1)
            {
                sb.Append("Incorrect username is entered<br>");
            }

            if (L.password != password)
            {
                sb.Append("Incorrect password is entered");
            }

            return sb.ToString();
        }
    }
}