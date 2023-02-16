using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevBoost.Models
{
    public class AddModel
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public string SelectedValue { get; set; }
        public IEnumerable<SelectListItem> Values { get; set; }
    }
}
