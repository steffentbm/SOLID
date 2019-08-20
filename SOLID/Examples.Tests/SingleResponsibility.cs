using System;
using Examples.Single_responsibility;
using NUnit.Framework;

namespace Examples.Tests
{
    public class SingleResponsibility
    {
        [Test]
        [TestCase("invalid_email_address.com", "123456")]
        [TestCase("foo", "bar")]
        public void InvalidEmails(string email, string password)
        {
            var user = new User(email, password);
            Assert.Throws<FormatException>(() => UserService.Register(user));
        }

        [Test]
        [TestCase("foo@bar.com", "password123")]
        [TestCase("foobar@foobar.com", "foobar")]
        public void ValidEmails(string email, string password)
        {
            var user = new User(email, password);
            Assert.DoesNotThrow(() => UserService.Register(user));
        }
    }
}