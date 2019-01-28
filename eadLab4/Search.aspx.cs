using eadLab4.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eadLab4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            tripdetails tripObj = new tripdetails();
            tripdetailsDAO tripDao = new tripdetailsDAO();
            tripObj = tripDao.getTripByCode(tbSearch.Text);
            if (tripObj != null)
            {
                PanelSearch.Visible = true;
                Lbl_triplocation.Text = tripObj.location;
                Lbl_triptype.Text = tripObj.type;
                Lbl_tripduration.Text = tripObj.duration;
                Lbl_tripcost.Text = tripObj.cost;
                Lbl_err.Text = String.Empty;
            }
            else
            {
                Lbl_err.Text = "Search of trip record not found!";
                PanelSearch.Visible = false;
                Lbl_triplocation.Text = String.Empty;
                Lbl_triptype.Text = String.Empty;
                Lbl_tripduration.Text = String.Empty;
                Lbl_tripcost.Text = String.Empty;
            }
        }

        protected void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}