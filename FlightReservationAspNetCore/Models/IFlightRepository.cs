using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightReservationAspNetCore.Models
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetAllFlights();
        Flight GetPieById(int flightId);
    }
}
