using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightReservationAspNetCore.Models
{
    public class Flight
    {
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
        public float distance { get; set; }
        public string from { get; set; }
        public string destination { get; set; }
        public int flightId { get; set; }
        //public IPlane plane { get; set; }
    }
}
