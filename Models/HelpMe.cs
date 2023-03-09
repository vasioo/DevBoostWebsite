using DevBoost.Models.HelpModels;
using System.ComponentModel.DataAnnotations;
using static DevBoost.Data.DataConstants.HelpMessage;

namespace DevBoost.Models
{
    public class HelpMe : IHelpMessage
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        public string Email { get; set; }

        [Required]
        [StringLength(MessageMaxLength, MinimumLength = MessageMinLength)]
        public string Message { get; set; }
    }
}
