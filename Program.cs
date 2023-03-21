using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using DevBoost.Controllers;
using DevBoost.Models;
using DevBoost.Data.DBContexts;
using Microsoft.AspNetCore.Mvc.Razor;
using DevBoost.Data.MainAttributes;
using Microsoft.AspNetCore.Mvc;
using DevBoost.Data;

namespace DevBoost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                       
            var connectionString = builder
                .Configuration
                .GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException
                ("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<DevBoostDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<User>(
                options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddRoles<IdentityRole>()
                   .AddEntityFrameworkStores<DevBoostDbContext>();

            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });

            //builder.Services.AddMemoryCache();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error/500");
              
                //app.UseHsts();
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}