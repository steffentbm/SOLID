using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using Suggestions.Single_responsibility;

namespace Suggestions.Tests
{
    [TestFixture]
    public class SingleResponsibility
    {
        [Test]
        [TestCase("invalid_email_address.com", "123456")]
        [TestCase("foo", "bar")]
        public void InvalidEmailsThrowsException(string email, string password)
        {
            var user = new User(email, password);
            UserService userService = new UserService(new EmailService(), new UserRepository());

            Assert.Throws<ValidationException>(() => userService.Register(user));
        }

        [Test]
        [TestCase("foo@bar.com", "password123")]
        [TestCase("foobar@foobar.com", "foobar")]
        public void ValidEmailsDoesNotThrowException(string email, string password)
        {
            var user = new User(email, password);
            UserService userService = new UserService(new EmailService(), new UserRepository());

            Assert.DoesNotThrow(() => userService.Register(user));
        }
    }
}