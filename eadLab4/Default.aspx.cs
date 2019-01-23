using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eadLab4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImgBtnStudentLogin_Click(object sender, ImageClickEventArgs e)
        {
            Session["ssRole"] = LblStudent.Text;
            Response.Redirect("Login.aspx");
        }

        protected void ImageBtnStaffLogin_Click(object sender, ImageClickEventArgs e)
        {
            Session["ssRole"] = LblStaff.Text;
            Response.Redirect("Login.aspx");
        }

        protected void ImageBtnAdminLogin_Click(object sender, ImageClickEventArgs e)
        {
            Session["ssRole"] = LblAdmin.Text;
            Response.Redirect("Login.aspx");
        }
    }
}