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
                StoreToDatabase(data);
            }
            catch (Exception e)
            {
                // Console logger
                Console.WriteLine(e);

                // File logger
                File.WriteAllText("errors.log", e.Message);

                // More loggers...?
            }
        }

        private static void StoreToDatabase(string data)
        {
            throw new Exception("Didn't find a database!");
        }
    }
}