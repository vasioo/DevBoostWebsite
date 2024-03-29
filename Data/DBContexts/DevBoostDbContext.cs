﻿using DevBoost.Data.MainAttributes;
using DevBoost.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevBoost.Data.DBContexts
{
    public class DevBoostDbContext : IdentityDbContext<User>
    {
        private bool seedDb;
        public DevBoostDbContext(DbContextOptions<DevBoostDbContext> options, bool seedDb = true)
            : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            this.seedDb = seedDb;
        }

        public DevBoostDbContext(){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Exercise> ExerciseTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DevBoost;Trusted_Connection=True;");
        }
    }
}
