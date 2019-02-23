using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightReservationAspNetCore.Models
{
    public class Customer
    {
        public string Name;
        public Dictionary<Flight, List<string>> BookedFlights = new Dictionary<Flight, List<string>>();
    }
}
