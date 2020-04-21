using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Database_Design.Models;

namespace Database_Design.Controllers
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
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Support()
        {
            return View();
        }
        public IActionResult TechSupport()
        {
            return View();
        }
        public IActionResult ReportContent()
        {
            return View();
        }
        public IActionResult MessageCreator()
        {
            return View();
        }


        public IActionResult AccountCreation()
        {
            return View();
        }
        public IActionResult ThankUser(AccountModel input)
        {
            Repository.AddResponse(input);
            return View("ThankUser", input);
        }
        public IActionResult Profile()
        {
            return View(Repository.Responses);
        }
        public IActionResult List()
        {
            return View(Repository.Responses);
        }
        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
