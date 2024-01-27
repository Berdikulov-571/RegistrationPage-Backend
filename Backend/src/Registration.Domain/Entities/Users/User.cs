namespace Registration.Domain.Entities.Users
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}