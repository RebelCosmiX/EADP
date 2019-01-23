using eadLab5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eadLab5
{
    public partial class ViewCustTrip : System.Web.UI.Page
    {
        string userId = "";
        custTripDao ctDao = new custTripDao();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id"].ToString() == "")
                    Response.Redirect("Trip.aspx");
                     userId = Session["id"].ToString();

                Label1.Text = userId;


                bind();

            }
        }
        private void bind()
        {
            DataList1.DataSource = ctDao.GetTrips(userId);
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            ctDao.deleteTrip(e.CommandArgument.ToString());
            bind();
        }
    }
}