using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Suggestions.Single_responsibility
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            if (!EmailService.ValidateEmail(email))
                throw new ValidationException("Provided email address is not valid");

            var user = new User(email, password);

            EmailService.SendEmail(new MailMessage("mysite@nowhere.com", user.Email) {Subject = "Hello", Body = $"Your password is {user.Password}"});
        }
    }
}