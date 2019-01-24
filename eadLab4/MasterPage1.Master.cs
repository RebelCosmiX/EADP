using System;
using eadLab4.Controller;
using eadLab4.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eadLab4
{
    public partial class MasterPage1 : System.Web.UI.MasterPage
    {
        MasterPageController MC = new MasterPageController();
        MasterPageDAO dao = new MasterPageDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            ImgBtnLogOut.CausesValidation = false;
            if(Session["User"] != null)
            {
                LblWelcome.Text = "Welcome, " + dao.getName(Session["ssLogin"].ToString(), Session["User"].ToString());
                LblWelcome.Visible = true;
                ImgBtnLogOut.Visible = true;
                MC.ShowUserFunction(Session["User"].ToString(), form1);
            }
        }

        protected void ImgBtnLogOut_Click(object sender, ImageClickEventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("~/Default.aspx");
        }
    }
}