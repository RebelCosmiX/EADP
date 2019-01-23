using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eadLab4.Controller
{
    public class MasterPageController
    {
        public void ShowUserFunction(string role, Control c)
        {
            foreach(var item in c.Controls)
            {
                if (item is HyperLink)
                    if(((HyperLink)item).ID.Contains("HyperLink" + role + "Func"))
                    {
                        ((HyperLink)item).Visible = true;
                    }
            }
        }
    }
}