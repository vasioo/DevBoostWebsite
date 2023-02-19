using DevBoost.Data;
using DevBoost.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly Exercise _exercise;
        private readonly ILogger<ExercisesController> _logger;

        public ExercisesController(ILogger<ExercisesController> logger, DevBoostDbContext dbc,Exercise exercise)
        {
            _logger = logger;
            _dbc = dbc;
            _exercise = exercise;
        }

        private readonly DevBoostDbContext _dbc;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HTMLCSS()
        {
            return View();
        }

        public IActionResult CSharpBeginning()
        {
            return View();
        }

        public IActionResult JavascriptBeginning()
        {
            return View();
        }

        public IActionResult CSharpHigh()
        {
            return View();
        }

        public IActionResult ASP()
        {
            return View();
        }

        public IActionResult DSA()
        {
            return View();
        }

        public IActionResult JavascriptHigh()
        {
            return View();
        }

        public IActionResult Bootstrap()
        {
            return View();
        }

        public IActionResult ReactJS()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(TaskFormModel tfm)
        {
            _dbc.Add(tfm);
            _dbc.SaveChanges();
            ViewBag.message = "The Record is saved successfully!";
            return View(tfm);
        }

    
    }
}
