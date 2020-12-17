using System;

namespace Events
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, VideoEventArgs video)
        {
            Console.WriteLine($"[SmsService] Sending SMS regarding \"{video.Video.Title}\"...");
        }
        
        public void OnVideoEncoded_WithoutArguments(object source, EventArgs args)
        {
            Console.WriteLine($"[SmsService] Sending mail...");
        }
    }
}