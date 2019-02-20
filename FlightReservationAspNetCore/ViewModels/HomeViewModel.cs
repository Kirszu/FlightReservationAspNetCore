using FlightReservationAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightReservationAspNetCore.ViewModels
{
    public class HomeViewModel
    {
        public List<Flight> Flights { get; set; }
    }
}
