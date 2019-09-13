using System.IO;

namespace Suggestions.Dependency_inversion.Logging
{
    public class FileLogger : ILogger
    {
        private readonly string _filename;

        public FileLogger(string filename)
        {
            _filename = filename;
        }

        public void Log(string text)
        {
            File.WriteAllText(_filename, text);
        }
    }
}