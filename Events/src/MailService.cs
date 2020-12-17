using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs video)
        {
            Console.WriteLine($"[MailService] Sending mail regarding \"{video.Video.Title}\"...");
        }
        
        public void OnVideoEncoded_WithoutArguments(object source, EventArgs args)
        {
            Console.WriteLine($"[MailService] Sending mail...");
        }
    }
}