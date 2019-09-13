using System;
using System.Collections.Generic;
using Examples.Interface_segregation;
using NUnit.Framework;

namespace Examples.Tests
{
    [TestFixture]
    public class InterfaceSegregation
    {
        private List<ILead> _employees;

        [OneTimeSetUp]
        public void Setup()
        {
            _employees = new List<ILead>
            {
                new Manager(),
                new Manager(),
                new TeamLead(),
                new TeamLead()
            };
        }

        [Test]
        public void EveryoneCanAssignTasks()
        {
            Assert.DoesNotThrow(() => _employees.ForEach(employee => employee.AssignTask()));
        }

        [Test]
        public void EveryoneCanCreateTasks()
        {
            Assert.DoesNotThrow(() => _employees.ForEach(employee => employee.CreateTask()));
        }

        [Test]
        public void ManagersCantWorkOnTasks()
        {
            Assert.Throws<NotImplementedException>(() => _employees.ForEach(employee => employee.WorkOnTask()));
        }
    }
}