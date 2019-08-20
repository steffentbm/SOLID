using System;
using Examples.Single_responsibility;

namespace Examples
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            SingleResponsibility();

            Console.ReadLine();
        }

        private static void SingleResponsibility()
        {
            var service = new UserService();
            var users = new[]
            {
                new User("foo", "bar"),
                new User("foo@bar.com", "password123"),
                new User("foobar@foobar.com", "foobar"), 
            };

            foreach (var user in users)
            {
                try
                {
                    service.Register(user.Email, user.Password);
                    Console.WriteLine($"{user.Email} successfully registered!");
                }
                catch (Exception)
                {
                    Console.WriteLine($"{user.Email} failed to register");
                }
            }
        }
    }
}
