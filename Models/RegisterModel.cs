﻿using DevBoost.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static DevBoost.Data.DataConstants.User;

namespace DevBoost.Models
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IMemoryCache cache;

        public RegisterModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager
            , IMemoryCache cache)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.cache = cache;
        }


        [BindProperty]
        public InputModel Input { get; set; }


        public string ReturnUrl { get; set; }

        public class InputModel
        {

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Name")]
            [StringLength(FirstNameMaxLength)]
            public string Name { get; set; }


            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

        }

        [HttpGet]
        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var fullName = Input.Name.Split(' ');
                var user = new User
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = fullName[0],
                    LastName = fullName[1],
                };

                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }
    }
}
