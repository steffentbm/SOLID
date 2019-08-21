using System;
using Examples.Open_closed;
using NUnit.Framework;

namespace Examples.Tests
{
    [TestFixture]
    public class OpenClosed
    {
        [Test]
        [TestCase(CustomerType.Gold, 100, 50)]
        [TestCase(CustomerType.Silver, 100, 75)]
        [TestCase(CustomerType.Bronze, 100, 90)]
        public void CalculatesCorrectDiscountedPrice(CustomerType customerType, double originalPrice, double expectedPrice)
        {
            var customer = new Customer(customerType);
            var discountedPrice = originalPrice - customer.GetDiscount(originalPrice);

            Assert.That(discountedPrice, Is.EqualTo(expectedPrice));
        }

        [Test]
        [TestCase(CustomerType.Gold, 5)]
        [TestCase(CustomerType.Silver, 2)]
        [TestCase(CustomerType.Bronze, 0)]
        public void GetMaxSandwiches(CustomerType customerType, int expectedNumberOfAllowedSandwiches)
        {
            var customer = new Customer(customerType);

            if (customer.HasAccessToLounge)
                Assert.That(customer.AllowedNumberOfSandwichesToEatInLounge, Is.EqualTo(expectedNumberOfAllowedSandwiches));
            else
                Assert.That(() => customer.AllowedNumberOfSandwichesToEatInLounge, Throws.Exception.TypeOf<UnauthorizedAccessException>());
        }
    }
}