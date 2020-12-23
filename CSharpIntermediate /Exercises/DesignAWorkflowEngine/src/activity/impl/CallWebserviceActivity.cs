using System;

namespace DesignAWorkflowEngine
{
    public class CallWebserviceActivity: IActivity
    {
        public void Run()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding. ");
        }
    }
}