using Registration.Domain.Attibutes.Email;
using Registration.Domain.Attibutes.Password;

namespace Registration.Domain.Dtos.Users
{
    public class UserRegistration
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        [Email]
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        [Password]
        public string Password { get; set; } = default!;
    }
}