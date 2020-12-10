using System;

namespace PolymorphismWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // var videoEncoder = new VideoEncoder();
            // videoEncoder.Encode(new Video());
            
            // Declare and initialize a VideoEncoder instance
            var videoEncoder = new VideoEncoder();
            
            // Register notification channels
            videoEncoder.RegisterNotificationChannel(new MailChannel());
            videoEncoder.RegisterNotificationChannel(new SmsChannel());
            
            // Encode the video
            videoEncoder.Encode(new Video("Funny cat compilation"));
        }
    }
}