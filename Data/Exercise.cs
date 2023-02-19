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
        SqlConnection con = new SqlConnection();

        List<Exercise> ExercisesList = new List<Exercise>();

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

        //public IEnumerable<ExerciseFormModel> Exercises { get; set; }
        //= new List<ExerciseFormModel>();
        Exercise e = null;

        public List<Exercise> All()
        {
            con.ConnectionString = "Server=.;Database=DevBoost;Trusted_Connection=True;";


             con.Open();

            using (con)
            {

                SqlCommand cmd = new SqlCommand("Select * from ExerciseTable", con);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())

                {

                    e = new Exercise();
                   

                    e.Title = Convert.ToString(rd.GetSqlValue(1));
                    e.Category = Convert.ToString(rd.GetSqlValue(2));
                    e.Name = Convert.ToString(rd.GetSqlValue(3));
                    e.Task = Convert.ToString(rd.GetSqlValue(4));
                    e.Input = Convert.ToString(rd.GetSqlValue(5));
                    e.Output = Convert.ToString(rd.GetSqlValue(6));

                    ExercisesList.Add(e);
                }
            }
            return ExercisesList;
        }

    }
}
