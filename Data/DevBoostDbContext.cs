using DevBoost.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevBoost.Data
{
    public class DevBoostDbContext: IdentityDbContext<User>
    {

        private bool seedDb;
        public DevBoostDbContext(DbContextOptions<DevBoostDbContext> options, bool seedDb = true)
            : base(options)
        {
            if (this.Database.IsRelational())
            {
                this.Database.Migrate();
            }
            else
            {
                this.Database.EnsureCreated();
            }

            this.seedDb = seedDb;
        }


       // public DbSet<TaskFormModel> ExerciseTable{ get; set; }

        public DbSet<ExerciseFormModel> ExerciseTable{ get; set; }
    }
}
