
namespace KProject
{
    public class User: Person
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public User(string email, string password, UserType userType, string name, string phone) : base(name, phone)
        {
            Email = email;
            Password = password;
            UserType = userType;
        }
    }
}
