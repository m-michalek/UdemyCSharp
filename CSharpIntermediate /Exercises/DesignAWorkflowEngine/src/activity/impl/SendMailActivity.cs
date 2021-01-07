using System;

namespace DesignAWorkflowEngine
{
    public class SendMailActivity: IActivity
    {
        public void Run()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}