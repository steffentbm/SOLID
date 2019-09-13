using NUnit.Framework;
using Suggestions.Dependency_inversion;
using Suggestions.Dependency_inversion.Logging;

namespace Suggestions.Tests
{
    [TestFixture]
    public class DependencyInversion
    {
        [Test]
        public void LogExceptionsToConsole()
        {
            var database = new Database();
            var logger = new ConsoleLogger();

            database.Save("important data", logger);
        }

        [Test]
        public void LogExceptionsToFile()
        {
            var database = new Database();
            var logger = new FileLogger("error.log");

            database.Save("important data", logger);
        }
    }
}