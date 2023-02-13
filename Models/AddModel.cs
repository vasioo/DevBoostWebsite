using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevBoost.Models
{
    public class AddModel
    {
        public string SelectedValue { get; set; }
        public IEnumerable<SelectListItem> Values { get; set; }
    }
}
