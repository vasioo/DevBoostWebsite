﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Controllers
{
    public partial class CardController : Controller
    {
        public IActionResult FlipCard()
        {
            return View();
        }
    }

}
