using DevBoost.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace DevBoost.Controllers
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
            return View("~/Views/Home/Navigation/Index.cshtml");
        }

        public IActionResult Privacy()
        {
            return View("~/Views/Home/Navigation/Privacy.cshtml");
        }

        public IActionResult Exercises()
        {
            return View("~/Views/Home/Navigation/Exercises.cshtml");
        }

        public IActionResult Community()
        {
            return View("~/Views/Home/Navigation/Community.cshtml");
        }

        public IActionResult Pricing()
        {
            return View("~/Views/Home/Navigation/Pricing.cshtml");
        }

        [HttpGet]
        public IActionResult Help()
        {
            return View("~/Views/Home/Navigation/Help.cshtml");
        }

        public IActionResult Entering()
        {
            return View("~/Views/Home/Navigation/Entering.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}