using System;
using Suggestions.Dependency_inversion.Logging;

namespace Suggestions.Dependency_inversion
{
    public class Database
    {
        public void Save(string data, ILogger logger)
        {
            try
            {
                StoreToDatabase(data);
            }
            catch (Exception e)
            {
                logger.Log(e.Message);
            }
        }

        private static void StoreToDatabase(string data)
        {
            throw new Exception("Didn't find a database!");
        }
    }
}