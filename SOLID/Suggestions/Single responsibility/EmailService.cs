using System;
using System.ComponentModel.DataAnnotations;

namespace Suggestions.Single_responsibility
{
    public class EmailService
    {
        public void SendWelcomeEmail(string address)
        {
            if (!IsEmailAddressValid(address))
                throw new ValidationException("Email address not valid!");

            // TODO: Send the actual mail

            Console.WriteLine($"Sent welcome email to: {address}");
        }

        private static bool IsEmailAddressValid(string address)
        {
            return address.Contains("@");
        }
    }
}