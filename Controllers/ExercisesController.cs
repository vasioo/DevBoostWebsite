using DevBoost.Data;
using DevBoost.Data.DBContexts;
using DevBoost.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly ILogger<ExercisesController> _logger;

        public ExercisesController(ILogger<ExercisesController> logger, DevBoostDbContext dbc)
        {
            _logger = logger;
            _dbc = dbc;
        }

        private readonly DevBoostDbContext _dbc;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HTMLCSS()
        {
            using (var db = new DevBoostDbContext())
            {
                var menuItems = db.ExerciseTable.ToList();
                return View(menuItems);
            }
        }

        public IActionResult CSharpBeginning()
        {
            return HTMLCSS();
        }

        public IActionResult JavascriptBeginning()
        {
            return HTMLCSS();
        }

        public IActionResult CSharpHigh()
        {
            return HTMLCSS();
        }

        public IActionResult ASP()
        {
            return HTMLCSS();
        }

        public IActionResult DSA()
        {
            return HTMLCSS();
        }

        public IActionResult JavascriptHigh()
        {
            return HTMLCSS();
        }

        public IActionResult Bootstrap()
        {
            return HTMLCSS();
        }

        public IActionResult ReactJS()
        {
            return HTMLCSS();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Exercise tfm)
        {
            _dbc.Add(tfm);
            _dbc.SaveChanges();
            ViewBag.message = "The Record is saved successfully!";
            Thread.Sleep(1000);
            return View("~/Views/Home/Navigation/Exercises.cshtml");
        }
    }
}
