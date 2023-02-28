using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static DevBoost.Data.DataConstants.User;

namespace DevBoost.Data.MainAttributes
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string? LastName { get; set; }
    }
}
