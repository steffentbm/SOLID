using System;

namespace Suggestions.Dependency_inversion.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}