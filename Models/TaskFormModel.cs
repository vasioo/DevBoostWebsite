using DevBoost.Services;
using System.ComponentModel.DataAnnotations;
using static DevBoost.Data.DataConstants.Adding;
using DevBoost.Models;

namespace DevBoost.Models
{
    public class TaskFormModel:IExercise
    {
        //TODO: add a mapping profiler 

        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Task { get; set; }

        [Required]
        [StringLength(InputMaxLength, MinimumLength = InputMinLength)]
        public string Input { get; set; }

        [Required]
        [StringLength(OutputMaxLength, MinimumLength = OutputMinLength)]
        public string Output { get; set; }


        public IEnumerable<TaskCategoryServiceModel> Categories { get; set; }
        = new List<TaskCategoryServiceModel>();
    }
}
