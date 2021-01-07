using System;

namespace Events
{
    public class SmsService
    {
        // Handle event
        public void OnVideoEncoded(object source, VideoEventArgs video)
        {
            Console.WriteLine($"[SmsService] Sending SMS regarding \"{video.Video.Title}\"...");
        }
        
        // Handle event
        public void OnVideoEncoded_WithoutArguments(object source, EventArgs args)
        {
            Console.WriteLine($"[SmsService] Sending mail...");
        }
    }
}