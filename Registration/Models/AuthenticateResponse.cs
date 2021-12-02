using Registration.Entities;

namespace Registration.Models
{
    public class AuthenticateResponse
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Name = user.Name;
            Login = user.Login;
            Phone = user.Phone;
            Email = user.Email;
            Token = token;
        }
    }
}
