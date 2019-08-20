using System.Net.Mail;

namespace Suggestions.Single_responsibility
{
    public class EmailClient
    {
        private string _host;
        public EmailClient(string host)
        {
            _host = host;
        }

        public void Send(MailMessage message)
        {
            // Send the mail
        }
    }
}