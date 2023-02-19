using DevBoost.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Controllers
{
    public class InnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
