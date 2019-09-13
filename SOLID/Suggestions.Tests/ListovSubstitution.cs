using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Suggestions.Liskov_substitution;

namespace Suggestions.Tests
{
    [TestFixture]
    public class ListovSubstitution
    {
        private List<ICanGetPrice> _priceEnquiries;
        private List<IHasBonusPoints> _customers;

        [OneTimeSetUp]
        public void Setup()
        {
            _priceEnquiries = new List<ICanGetPrice>
            {
                new Customer(),
                new Customer(),
                new Enquiry(),
                new Enquiry()
            };

            _customers = new List<IHasBonusPoints>
            {
                new Customer(),
                new Customer()
            };
        }

        [Test]
        public void CanAddBonusPointsToCustomers()
        {
            Assert.DoesNotThrow(() =>_customers.ForEach(customer => customer.AddBonusPoints(10)));
        }

        [Test]
        public void CanSumUpPricesForAllCustomers()
        {
            Assert.That(_priceEnquiries.Sum(enquiry => enquiry.GetPrice()), Is.EqualTo(400));
        }
    }
}