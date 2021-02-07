using System;
using System.Threading;

namespace EventLab
{
    // 1. create delegate
    // 2. Define event based on that delegate 
    // 3. Raise event
    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video ...");
            Thread.Sleep(3000); // 3s 
            OnVideoEncoded(video); // raise
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs { Video = video });
        }
    }
}
