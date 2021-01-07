using System;

namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video {Title = "A funny video"};
            var mailService = new MailService();
            var smsService = new SmsService();
            var videoEncoder = new VideoEncoder();

            Console.WriteLine("[Program] Register events...");
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            videoEncoder.VideoEncodedWithoutArguments += mailService.OnVideoEncoded_WithoutArguments;
            videoEncoder.VideoEncodedWithoutArguments += smsService.OnVideoEncoded_WithoutArguments;

            videoEncoder.Encode(video);
        }
    }
}