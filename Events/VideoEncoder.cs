using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //Step 1 - Define an event via EventHandler<T> delegate - The return type is void in events
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding {video.Title}...");
            Thread.Sleep(3000);

            //Step 3 - Raise the event
            OnVideoEncoded(video);
        }


        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs { Video = video });
            }
        }
    }
}