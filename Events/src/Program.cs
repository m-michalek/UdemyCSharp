namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video();
            var mailService = new MailService();
            var smsService = new SmsService();
            var videoEncoder = new VideoEncoder();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            
            videoEncoder.Encode(video);
        }
    }
}