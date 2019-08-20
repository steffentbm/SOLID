using System.Net.Mail;

namespace Suggestions.Single_responsibility
{
    public class EmailService
    {
        public static bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public static void SendEmail(MailMessage message)
        {
            new EmailClient("smtp.nowhere.com").Send(message);
        }
    }
}