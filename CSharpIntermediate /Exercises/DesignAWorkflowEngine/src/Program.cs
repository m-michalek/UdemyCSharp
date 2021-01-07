using System.Collections.Generic;

namespace DesignAWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();

            workflowEngine.RegisterWorkflow(new Workflow
                {
                    Activities = new List<IActivity>
                    {
                        new UploadVideoActivity(),
                        new CallWebserviceActivity(),
                        new SendMailActivity(),
                        new ChangeVideoStatusActivity()
                    }
                }
            );
            workflowEngine.RegisterWorkflow(new Workflow
                {
                    Activities = new List<IActivity>
                    {
                        new UploadVideoActivity(),
                        new ChangeVideoStatusActivity()
                    }
                }
            );

            workflowEngine.Run();
        }
    }
}