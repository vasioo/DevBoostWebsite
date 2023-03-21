using DevBoost.Data.DBContexts;
using DevBoost.Models.ExerciseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using static DevBoost.Data.DataConstants.ExerciseConstraints;

namespace DevBoost.Data
{
    public class Exercise:IExercise
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


        public int LikesCount { get; set; }

        [NotMapped]
        public bool IsLiked { get; set; }

        [HttpPost]
        public async Task LikeAsync()
        {
            using (var context = new DevBoostDbContext())
            {
                var card = await context.ExerciseTable.FindAsync(Id);
                card.LikesCount++;
                await context.SaveChangesAsync();
                IsLiked = true;
            }
        }

        [HttpPost]
        public async Task UnlikeAsync()
        {
            using (var context = new DevBoostDbContext())
            {

                var card = await context.ExerciseTable.FindAsync(Id);
                if (card.LikesCount > 0)
                {
                    card.LikesCount--;
                    await context.SaveChangesAsync();
                    IsLiked = false;
                }
            }
        }


        [HttpPost]
        public static async Task<List<Exercise>> GetAllAsync()
        {
            using (var context = new DevBoostDbContext())
            {
                var cards = await context.ExerciseTable.ToListAsync();
                return cards;
            }
        }

        [HttpPost]
        public static async Task<Exercise> GetByIdAsync(int id)
        {
            using (var context = new DevBoostDbContext())
            {
                var card = await context.ExerciseTable.FindAsync(id);
                return card;
            }
        }
    }
}

