using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eadLab5.DAL
{
    public class Trip
    {
        public string id { get; set; }
        public string tripName { get; set; }
        public string tripDescription { get; set; }
        public string tripCountry { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
}