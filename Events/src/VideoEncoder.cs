using System;

namespace Events
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler VideoEncodedWithoutArguments;

        public void Encode(Video video)
        {
            Console.WriteLine("[VideoEncoder] Encoding video...");

            OnVideoEncoded(video);
            OnVideoEncodedWithoutArguments();
        }

        public void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs{Video = video});
        }

        public void OnVideoEncodedWithoutArguments()
        {
            if (VideoEncodedWithoutArguments != null)
                VideoEncodedWithoutArguments(this, EventArgs.Empty);
        }
    }
}