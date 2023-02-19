
using System.ComponentModel.DataAnnotations;

namespace DevBoost.Models
{
    public class ExerciseFormModel:ITaskModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Task { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Input { get; set; }

        [Required]
        public string Output { get; set; }

    }
}
