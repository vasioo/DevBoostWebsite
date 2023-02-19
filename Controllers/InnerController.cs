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
        public IActionResult All()
        {
            Exercise exercise = new Exercise();
            List<Exercise> list = new List<Exercise>();

            list = exercise.All();
            ViewData["Exercise"] = list;
            return View();
        }
    }
}
