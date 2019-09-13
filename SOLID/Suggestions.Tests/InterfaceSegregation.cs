using System.Collections.Generic;
using NUnit.Framework;
using Suggestions.Interface_segregation;
using Suggestions.Interface_segregation.Interfaces;

namespace Suggestions.Tests
{
    [TestFixture]
    public class InterfaceSegregation
    {
        private List<IAssign> _assigners;
        private List<ICreate> _creators;
        private List<IWork> _workers;

        [OneTimeSetUp]
        public void Setup()
        {
            _assigners = new List<IAssign>
            {
                new Manager(),
                new TeamLead()
            };
            _creators = new List<ICreate>
            {
                new Manager(),
                new TeamLead()
            };
            _workers = new List<IWork>
            {
                new TeamLead(),
                new Programmer()
            };
        }

        [Test]
        public void AssignersCanAssignTasks()
        {
            Assert.DoesNotThrow(() => _assigners.ForEach(employee => employee.AssignTask()));
        }

        [Test]
        public void CreatorsCanCreateTasks()
        {
            Assert.DoesNotThrow(() => _creators.ForEach(employee => employee.CreateTask()));
        }

        [Test]
        public void WorkersCanWorkOnTasks()
        {
            Assert.DoesNotThrow(() => _workers.ForEach(employee => employee.WorkOnTask()));
        }
    }
}