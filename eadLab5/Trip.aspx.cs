using eadLab5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eadLab5
{
    public partial class Trip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tripView();
        }

        private void tripView()
        {
            tripDao tripdao = new tripDao();

            DataList1.DataSource = tripdao.GetTrips();
            DataList1.DataBind();





        }
    }
}