using System;
using System.Text.Json.Serialization;

namespace Registration.Models.Accounts
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsVerified { get; set; }
        public string JwtToken { get; set; }

        [JsonIgnore] //токен обновлени€ возвращаетс€ в файле cookie только дл€ http
        public string RefreshToken { get; set; }
    }
}