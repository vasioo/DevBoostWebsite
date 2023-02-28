using DevBoost.Data;
using DevBoost.Data.DBContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevBoost.Controllers
{
    public class InnerController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new DevBoostDbContext())
            {
                var menuItems = db.ExerciseTable.ToList();
                return View($"~/Views/Exercises/Topics/{menuItems}");
            }
        }
    }
}
