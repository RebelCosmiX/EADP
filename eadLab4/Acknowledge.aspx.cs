using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eadLab4
{
    public partial class Acknowledge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["cname"].ToString();
            string email = Request.QueryString["cemail"].ToString();

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(email))
                LbMsg.Text = "Sorry, please provide your contact";
            else
                LbMsg.Text = "Thank you for the enquiry" + name + ", we will contact you sooner to your email " + email;
        }
    }
}