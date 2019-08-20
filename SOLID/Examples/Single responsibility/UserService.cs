using System;
using System.Net.Mail;

namespace Examples.Single_responsibility
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

    public static class UserService
    {
        public static void Register(User user)
        {
            if (!ValidateEmail(user.Email))
            {
                Console.WriteLine($"{user.Email} is not a valid email address");
                throw new FormatException("Provided email address is not valid");
            }


            SendEmail(new MailMessage("support@company.com", user.Email) {Subject = $"Welcome, {user.Email}!", Body = $"Your password is {user.Password}"});
        }

        private static bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        private static void SendEmail(MailMessage message)
        {
            // TODO: Send the actual mail
            Console.WriteLine($"Sent email with subject: {message.Subject}");
        }
    }
}