using System;
using System.IO;

namespace Examples.Dependency_inversion
{
    public class Database
    {
        public void Save(string data)
        {
            try
            {
                // Save the string to the database
            }
            catch (Exception e)
            {
                // Console logger
                Console.WriteLine(e);

                // File logger
                File.WriteAllText("log.txt", e.Message);
            }
        }
    }
}