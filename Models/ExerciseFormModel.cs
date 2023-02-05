
using System.ComponentModel.DataAnnotations;

namespace DevBoost.Models
{
    public class ExerciseFormModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Input { get; set; }

        [Required]
        public string Output { get; set; }

    }
}
