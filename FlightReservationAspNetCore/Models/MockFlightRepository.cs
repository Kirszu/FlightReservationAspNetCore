using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightReservationAspNetCore.Models
{
    public class MockFlightRepository : IFlightRepository
    {
        private List<Flight> _flights;

        public MockFlightRepository()
        {
            if (_flights == null)
            {
                InitializeFlights();
            }
        }

        private void InitializeFlights()
        {
            _flights = new List<Flight>
            {
                new Flight { departure = DateTime.Now, arrival = DateTime.Today, distance = 343, from = "WAW", destination = "LIS", flightId = 1 },
                new Flight { departure = DateTime.Now, arrival = DateTime.Today, distance = 121, from = "WAW", destination = "LAS", flightId = 2 },
                new Flight { departure = DateTime.Now, arrival = DateTime.Today, distance = 333, from = "WAW", destination = "WRO", flightId = 3 },
                new Flight { departure = DateTime.Now, arrival = DateTime.Today, distance = 344, from = "WAW", destination = "BER", flightId = 4},
                new Flight { departure = DateTime.Now, arrival = DateTime.Today, distance = 454, from = "WAW", destination = "ROM", flightId = 5 },
            };
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return _flights;
        }

        public Flight GetPieById(int Id)
        {
            return _flights.FirstOrDefault(f => f.flightId == Id);
        }
    }
}
