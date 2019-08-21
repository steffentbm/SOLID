using Suggestions.Interface_segregation.Interfaces;

namespace Suggestions.Interface_segregation
{
    public class TeamLead : ICreate, IAssign, IWork
    {
        public void AssignTask()
        {
            // Code to assign a task
        }

        public void CreateTask()
        {
            // Code to create a task
        }

        public void WorkOnTask()
        {
            // Code to work on a task
        }
    }
}