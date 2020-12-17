using System;

namespace Events
{
    public class VideoEncoder
    {
        public event EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("[VideoEncoder] Encoding video...");

            OnVideoEoncoded();
        }

        public void OnVideoEoncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }

    public class Video
    {
    }
}