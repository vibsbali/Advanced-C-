using System;
using System.Threading;

namespace Events
{
    internal class VideoEncoder
    {
        //Step 1 - Define a delegate
        //Step 2 - Define an event based on that delegate
        //Step 3 - Raise the event

        //Step 1 - Define a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //Step 2 - Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding {video.Title}...");
            Thread.Sleep(3000);

            //Step 3 - Raise the event
            OnVideoEncoded();
        }


        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}