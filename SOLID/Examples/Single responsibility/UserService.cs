using System;
using System.Collections.Generic;

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

    public class UserService
    {
        private IList<User> _users = new List<User>();

        public void Register(User user)
        {
            if (!ValidateEmail(user.Email))
            {
                Console.WriteLine($"{user.Email} is not a valid email address");
                throw new FormatException("Provided email address is not valid");
            }

            _users.Add(user);

            SendWelcomeEmail(user.Email);
        }

        private static bool ValidateEmail(string address)
        {
            return address.Contains("@");
        }

        private static void SendWelcomeEmail(string address)
        {
            // TODO: Send the actual mail
            Console.WriteLine($"Sent welcome email to: {address}");
        }
    }
}