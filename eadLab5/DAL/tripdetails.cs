using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eadLab5.DAL
{
    public class tripdetails
    {
        public tripdetails()
        {
        }
        public string tripCode { get; set; }
        public string tripName { get; set; }
        public string tripType { get; set; }
        public string tripCost { get; set; }
        public string tripDuration { get; set; }
    }
}