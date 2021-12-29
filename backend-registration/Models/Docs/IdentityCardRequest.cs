using System.ComponentModel.DataAnnotations;

namespace Registration.Models.Accounts
{
    public class IdentityCardRequest
    {
        [Required]
        public int NumberIdentityCard { get; set; }
    }
}
