using System;

namespace DesignAWorkflowEngine
{
    class ChangeVideoStatusActivity : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
}