using System;

namespace EventLab
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Title {args.Video.Title} - Sms was sent");
        }
    }
}
