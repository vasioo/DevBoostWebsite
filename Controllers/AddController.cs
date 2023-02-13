using DevBoost.Data;
using DevBoost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DevBoost.Controllers
{
    public class AddController : Controller
    {
        [HttpPost]
        public ActionResult Save(AddModel model)
        {
            // Add the selected value to the database
            using (var context = new DevBoostDbContext())
            {
                var newValue = new MyValue { Value = model.SelectedValue };
                context.Values.Add(newValue);
                context.SaveChanges();
            }

            return View(model);
        }

    }

    public ActionResult Index()
    {
        var model = new AddModel
        {
            Values = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Option 1" },
            new SelectListItem { Value = "2", Text = "Option 2" },
            new SelectListItem { Value = "3", Text = "Option 3" },
        }
        };

        return View(model);

    }
}
