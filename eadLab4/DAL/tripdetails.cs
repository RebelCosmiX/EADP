using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eadLab4.DAL
{
    public class tripdetails
    {
        public tripdetails()
        {
        }
        public string code { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string duration { get; set; }
        public string cost { get; set; }
    }
}