namespace Suggestions.Single_responsibility
{
    public class User
    {
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; }
        public string Password { get; }
    }
}