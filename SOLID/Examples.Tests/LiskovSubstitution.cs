using System;
using System.Collections.Generic;
using System.Linq;
using Examples.Liskov_substitution;
using NUnit.Framework;

namespace Examples.Tests
{
    [TestFixture]
    public class LiskovSubstitution
    {
        private List<Customer> _customers;

        [OneTimeSetUp]
        public void Setup()
        {
            _customers = new List<Customer>
            {
                new GoldCustomer(),
                new GoldCustomer(),
                new PriceEnquiry(),
                new PriceEnquiry()
            };
        }

        [Test]
        public void AddingBonusPointsToPriceEnquiryThrowsError()
        {
            Assert.Throws<NotImplementedException>(() => _customers.ForEach(customer => customer.AddBonusPoints(10)));
        }

        [Test]
        public void CanSumUpPricesForAllCustomers()
        {
            Assert.That(_customers.Sum(customer => customer.GetPrice()), Is.EqualTo(400));
        }
    }
}