using System;
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
            Assert.Throws<FormatException>(() => UserService.Register(user));
        }

        [Test]
        [TestCase("foo@bar.com", "password123")]
        [TestCase("foobar@foobar.com", "foobar")]
        public void ValidEmailsDoesNotThrowException(string email, string password)
        {
            var user = new User(email, password);
            Assert.DoesNotThrow(() => UserService.Register(user));
        }
    }
}