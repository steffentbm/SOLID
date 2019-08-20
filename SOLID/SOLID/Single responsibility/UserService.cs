using System;
using System.ComponentModel.DataAnnotations;
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

    public sealed class UserService
    {
        public static void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Provided email address is not valid");

            var user = new User(email, password);

            SendEmail(new MailMessage("support@company.com", user.Email) {Subject = $"Welcome, {user.Email}!", Body = $"Your password is {user.Password}"});
        }

        private static bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        private static void SendEmail(MailMessage message)
        {
            Console.WriteLine($"Sent email with subject: {message.Subject}");
        }
    }
}