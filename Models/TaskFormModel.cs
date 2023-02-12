using DevBoost.Services;
using System.ComponentModel.DataAnnotations;
using static DevBoost.Data.DataConstants.Adding;

namespace DevBoost.Models
{
    public class TaskFormModel
    {
        //TODO: add a mapping profiler 

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string? Title { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string? Description { get; set; }

        [Required]
        [StringLength(InputMaxLength, MinimumLength = InputMinLength)]
        public string? Input { get; set; }

        [Required]
        [StringLength(OutputMaxLength, MinimumLength = OutputMinLength)]
        public string? Output { get; set; }


        public IEnumerable<TaskCategoryServiceModel> Categories { get; set; }
        = new List<TaskCategoryServiceModel>();
    }
}
