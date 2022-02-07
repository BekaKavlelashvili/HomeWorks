using Homework_13_exercise1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_13_exercise1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/contact", Name = "Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        [Route("/contact", Name = "Contact")]
        public IActionResult Index(PersonModel person)
        {
            //aq jsonshi ver vinaxav. 

            //var path = @"C:\Users\Beka\source\repos\Homework_13\Homework_13_exercise1\Data.json";
            string firstName = person.FirstName;
            //FileContentResult.Equals(firstName, path);
            string lastName = person.LastName;
            //FileContentResult.Equals(lastName, path);
            string doctor = person.Doctor;
            //FileContentResult.Equals( doctor, path);
            int time = person.Time;
            //FileContentResult.Equals(time, path);
            return View();
        }
    }
}
