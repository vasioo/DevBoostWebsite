using DevBoost.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize]
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

        [HttpPost]
        public IActionResult Pricing(string whichButton)
        {
            switch (whichButton)
            {
                case "1":
                    ViewBag.Text = "9.99/once +VAT";
                    break;
                case "2":
                    ViewBag.Text = "17.98/month +VAT";
                    break;
                case "3":
                    ViewBag.Text = "49.95/month +VAT";
                    break;
            }
            return View("~/Views/Pricing/Purchasing.cshtml");
        }


        [HttpGet]
        public IActionResult Help()
        {
            return View("~/Views/Home/Navigation/HelpMe.cshtml");
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Help(HelpMe hp)
		{
			return View("~/Views/Home/Errors/StillBuilding.cshtml");
		}
	}
}