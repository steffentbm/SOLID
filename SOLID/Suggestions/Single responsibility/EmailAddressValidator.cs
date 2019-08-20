using System;
using System.Net.Mail;

namespace Suggestions.Single_responsibility
{
    public static class EmailAddressValidator
    {
        public static void ValidateEmailAddress(MailAddressCollection mailAddressCollection)
        {
            foreach (var mailAddress in mailAddressCollection) ValidateEmailAddress(mailAddress.Address);
        }

        private static void ValidateEmailAddress(string email)
        {
            if (IsEmailAddressValid(email)) return;

            Console.WriteLine($"{email} is not a valid email address");
            throw new FormatException("Provided email address is not valid");
        }

        private static bool IsEmailAddressValid(string email)
        {
            return email.Contains("@");
        }
    }
}