using Examples.Dependency_inversion;
using NUnit.Framework;

namespace Examples.Tests
{
    [TestFixture]
    public class DependencyInversion
    {
        [Test]
        public void HopeThisLogsSomethingIfAnythingGoesWrong()
        {
            var database = new Database();

            database.Save("important data");
        }
    }
}