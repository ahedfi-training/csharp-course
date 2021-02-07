namespace EventLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Matrix" };
            var videoEncoder = new VideoEncoder(); //Publisher

            var mailService = new MailService(); // Subscriber
            var smsService = new SmsService(); // Subscriber

            //Subscription
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;


            videoEncoder.Encode(video);
        }
    }
}
