using System.Collections.Generic;
using System.Text;

namespace DesignAWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();

            workflowEngine.RegisterWorkflow(new List<IActivity>
                {
                    new UploadVideoActivity(),
                    new CallWebserviceActivity(),
                    new SendMailActivity(),
                    new ChangeVideoStatusActivity()
                }
            );
            workflowEngine.RegisterWorkflow(new List<IActivity>
                {
                    new UploadVideoActivity(),
                    new CallWebserviceActivity()
                }
            );

            workflowEngine.Run();
        }
    }
}