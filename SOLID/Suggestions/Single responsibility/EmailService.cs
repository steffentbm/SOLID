using System;
using System.Net.Mail;

namespace Suggestions.Single_responsibility
{
    public static class EmailService
    {
        public static void SendEmail(MailMessage message)
        {
            EmailAddressValidator.ValidateEmailAddress(message.To);

            // TODO: Send the actual mail
            Console.WriteLine($"Sent email with subject: {message.Subject}");
        }

        public static MailMessage StandardWelcomeMessage(User user)
        {
            return new MailMessage("support@company.com", user.Email, $"Welcome, {user.Email}!", $"Your password is {user.Password}");
        }
    }
}