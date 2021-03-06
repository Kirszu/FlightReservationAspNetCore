﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightReservationAspNetCore.Models;
using FlightReservationAspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightReservationAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFlightRepository _flightRepository;

        public HomeController(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var flights = _flightRepository.GetAllFlights();

            var homeViewModel = new HomeViewModel()
            {
                Flights = flights.ToList()
            };
            return View(homeViewModel);
        }
    }
}
