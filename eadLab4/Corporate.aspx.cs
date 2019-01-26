//using eadLab4.DAL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace eadLab4
//{
//    public partial class Corporate : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        protected void Button1_Click1(object sender, EventArgs e)
//        {
//            customer cusObj = new customer();
//            customerDAO cusDao = new customerDAO();

//            cusObj = cusDao.login(TextBox1.Text, TextBox2.Text);
//            if (cusObj != null)
//            {
//                Session["id"] = cusObj.customerId;
//                Response.Redirect("ViewCustTrip.aspx");
//            }
//            else
//            {
//                Session["id"] = null;
//            }
                


//        }
//    }
//}