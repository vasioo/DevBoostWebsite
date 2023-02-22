﻿using DevBoost.Data;
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
        public IActionResult Add(Exercise tfm)
        {
            _dbc.Add(tfm);
            _dbc.SaveChanges();
            ViewBag.message = "The Record is saved successfully!";
            return View(tfm);
        }
    }
}
