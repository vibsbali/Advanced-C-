using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"{e.Video.Title} encoded... MailService: Sending an email....");
        }
    }
}