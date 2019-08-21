using System;

namespace Examples.Interface_segregation
{
    public class Manager : ILead
    {
        public void CreateTask()
        {
            // Code to create a task
        }

        public void AssignTask()
        {
            // Code to assign a task
        }

        public void WorkOnTask()
        {
            throw new NotImplementedException("Managers don't know how to code!");
        }
    }
}