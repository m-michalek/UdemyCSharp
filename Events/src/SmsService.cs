using System;

namespace Events
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("[SmsService] Sending SMS...");
        }
    }
}