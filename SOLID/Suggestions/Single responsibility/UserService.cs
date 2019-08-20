namespace Suggestions.Single_responsibility
{
    public static class UserService
    {
        public static void Register(User user)
        {
            EmailService.SendEmail(EmailService.StandardWelcomeMessage(user));
        }
    }
}