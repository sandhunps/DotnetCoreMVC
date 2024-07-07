using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["appTitle"] = "Asp.Net Core Demo App";

            List<Person> people = new List<Person>()
            {
                new Person() { Name = "John", Dob = DateTime.Parse("2000-05-06"), Gender = Gender.Male},
                new Person() { Name = "Linda", Dob = DateTime.Parse("2005-01-09"), Gender = Gender.Female},
                new Person() { Name = "Susan", Dob = DateTime.Parse("2008-07-12"), Gender = Gender.Other}
            };
           // ViewData["people"] = people;
           // instead of ViewData you can directly use ViewBag
            ViewBag.people = people;

            return View(); //Views/Home/Index.cshtml
        }

        [Route("Basics")]
        public IActionResult Basics()
        {
            return View();
        }

        [Route("ViewBag_ViewData")]
        public IActionResult ViewBag_ViewData()
        {
            ViewData["appTitle"] = "Asp.Net Core Demo App";

            List<Person> people = new List<Person>()
            {
                new Person() { Name = "John", Dob = DateTime.Parse("2000-05-06"), Gender = Gender.Male},
                new Person() { Name = "Linda", Dob = DateTime.Parse("2005-01-09"), Gender = Gender.Female},
                new Person() { Name = "Susan", Dob = DateTime.Parse("2008-07-12"), Gender = Gender.Other}
            };
            // ViewData["people"] = people;
            // instead of ViewData you can directly use ViewBag
            ViewBag.people = people;

            return View(); //Views/Home/Index.cshtml
        }
    }
}

