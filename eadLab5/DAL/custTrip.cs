using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eadLab5.DAL
{
    public class custTrip
    {
        public int custTripId { get; set; }
        public int tripId { get; set; }

        public string custId { get; set; }
        public string tripName { get; set; }
        public string state { get; set; }

    }
}