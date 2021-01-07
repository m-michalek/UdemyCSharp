using System;
using System.Collections.Generic;

namespace DesignAWorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly List<Workflow> _workflows = new List<Workflow>();
        public void Run()
        {
            foreach (var workflow in _workflows)
            {
                Console.WriteLine("Running workflow:");
                
                foreach (var activity in workflow.Activities)
                {
                    activity.Run();   
                }

                Console.WriteLine();
            }
        }

        public void RegisterWorkflow(Workflow workflow)
        {
            _workflows.Add(workflow);
        }
    }
}