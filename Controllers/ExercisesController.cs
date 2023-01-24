using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly ILogger<ExercisesController> _logger;

        public ExercisesController(ILogger<ExercisesController> logger)
        {
            _logger = logger;
        }

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
    }
}
