using Suggestions.Interface_segregation.Interfaces;

namespace Suggestions.Interface_segregation
{
    public class Manager : ICreate, IAssign
    {
        public void AssignTask()
        {
            // Code to assign a task
        }

        public void CreateTask()
        {
            // Code to create a task
        }
    }
}