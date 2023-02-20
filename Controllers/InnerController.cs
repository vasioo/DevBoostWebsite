using DevBoost.Data;
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
                return View(menuItems);
            }
        }
    }
}
