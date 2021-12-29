using System.ComponentModel.DataAnnotations;

namespace Registration.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}