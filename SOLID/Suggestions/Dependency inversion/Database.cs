using System;

namespace Suggestions.Dependency_inversion
{
    public class Database
    {
        public void Save(string data, ILogger logger)
        {
            try
            {
                // Save the string to the database
            }
            catch (Exception e)
            {
                logger.Log(e.Message);
            }
        }
    }
}