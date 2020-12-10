using System;
using System.Collections.Generic;

namespace DesignAWorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly List<List<IActivity>> _workflows = new List<List<IActivity>>();
        public void Run()
        {
            foreach (var workflow in _workflows)
            {
                Console.WriteLine("Running workflow:");
                
                foreach (var activity in workflow)
                {
                    activity.Run();   
                }

                Console.WriteLine();
            }
        }

        public void RegisterWorkflow(List<IActivity> activities)
        {
            _workflows.Add(activities);
        }
    }
}