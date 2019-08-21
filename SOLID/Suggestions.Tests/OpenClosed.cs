using System.Collections.Generic;
using NUnit.Framework;
using Suggestions.Open_closed;

namespace Suggestions.Tests
{
    [TestFixture]
    public class OpenClosed
    {
        private static IEnumerable<TestCaseData> _customerTypesAndDiscounts = new[]
        {
            new TestCaseData(new GoldCustomer(), 100, 50),
            new TestCaseData(new SilverCustomer(), 100, 75),
            new TestCaseData(new BronzeCustomer(), 100, 90)
        };

        private static IEnumerable<TestCaseData> _customerTypesAndAllowedSandwiches = new[]
        {
            new TestCaseData(new GoldCustomer(), 5),
            new TestCaseData(new SilverCustomer(), 2)
        };

        [Test]
        [TestCaseSource(nameof(_customerTypesAndDiscounts))]
        public void CalculatesCorrectDiscountedPrice(Customer customer, double originalPrice, double expectedPrice)
        {
            var discountedPrice = originalPrice - customer.GetDiscount(originalPrice);

            Assert.That(discountedPrice, Is.EqualTo(expectedPrice));
        }

        [Test]
        [TestCaseSource(nameof(_customerTypesAndAllowedSandwiches))]
        public void GetMaxSandwiches(LoungeCustomer customer, int expectedNumberOfAllowedSandwiches)
        {
            Assert.That(customer.AllowedNumberOfSandwichesToEatInLounge, Is.EqualTo(expectedNumberOfAllowedSandwiches));
        }
    }
}