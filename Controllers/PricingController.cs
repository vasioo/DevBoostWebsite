using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Controllers
{
    public class PricingController : Controller
    {
        private readonly ILogger<PricingController> _logger;

        public PricingController(ILogger<PricingController> logger)
        {
            _logger = logger;
        }
        public IActionResult Purchasing()
        {
            return View();
        }
    }
}
