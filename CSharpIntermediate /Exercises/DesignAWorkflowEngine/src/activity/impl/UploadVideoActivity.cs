using System;
using System.Diagnostics;

namespace DesignAWorkflowEngine
{
    public class UploadVideoActivity: IActivity
    {
        public void Run()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}