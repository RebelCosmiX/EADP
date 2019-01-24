using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using eadLab4.Controller;
using System.Web.UI.WebControls;

namespace eadLab4
{
    public partial class Login : System.Web.UI.Page
    {
        LoginController LC = new LoginController();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = this.btnLogin.UniqueID;
            if (Session["ssRole"] == null)
            {
                Response.Redirect("MainPage.aspx");
            }
            else
            {
                LblLogin.Text = Session["ssRole"].ToString() + " Login";
            }



            LblResetPassword.Visible = true;
            LblResetPassword.Text = "Forgot <a href=\"SendEmailLink.aspx?Forgotten=Username\">Username</a> or <a href=\"SendEmailLink.aspx?Forgotten=Password\">Password</a>?";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string role = Session["ssRole"].ToString();
            string loginValidate = LC.ErrMsg(role, tbUsername.Text, tbPassword.Text);
            if (loginValidate == string.Empty)
            {
                Session["ssLogin"] = tbUsername.Text;
                Session["User"] = role;
                Response.Redirect("MainPage.aspx");
            }
            else
            {
                LblErr.Visible = true;
                LblErr.Text = loginValidate;
            }
        }
    }
}