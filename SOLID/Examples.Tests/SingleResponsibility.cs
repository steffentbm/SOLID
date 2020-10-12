using System;
using Examples.Single_responsibility;
using NUnit.Framework;

namespace Examples.Tests
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
            UserService userService = new UserService();

            Assert.Throws<FormatException>(() => userService.Register(user));
        }

        [Test]
        [TestCase("foo@bar.com", "password123")]
        [TestCase("foobar@foobar.com", "foobar")]
        public void ValidEmailsDoesNotThrowException(string email, string password)
        {
            var user = new User(email, password);
            UserService userService = new UserService();

            Assert.DoesNotThrow(() => userService.Register(user));
        }
    }
}