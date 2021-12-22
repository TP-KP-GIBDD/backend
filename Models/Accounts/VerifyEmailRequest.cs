using System.ComponentModel.DataAnnotations;

namespace Registration.Models.Accounts
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }
    }
}