using DevBoost.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System.ComponentModel.DataAnnotations;
using System.Net;
using static DevBoost.Data.DataConstants.ExerciseConstraints;

namespace DevBoost.Data
{
    public class Exercise
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string? Title { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string? Name { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string? Task { get; set; }

        [Required]
        [StringLength(InputMaxLength, MinimumLength = InputMinLength)]
        public string? Input { get; set; }

        [Required]
        [StringLength(OutputMaxLength, MinimumLength = OutputMinLength)]
        public string? Output { get; set; }

    }
}

