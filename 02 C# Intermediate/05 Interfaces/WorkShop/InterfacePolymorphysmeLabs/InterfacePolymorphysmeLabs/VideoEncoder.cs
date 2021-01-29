namespace InterfacePolymorphysmeLabs
{
    public class VideoEncoder
    {
        //private readonly MailService _mailService;
        private readonly INotifyService[] _notifyServices;

        public VideoEncoder(INotifyService[] notifyServices)
        {
            //_mailService = new MailService();
            _notifyServices = notifyServices;
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            //_mailService.Send(new Mail());
            foreach (var notifyService in _notifyServices)
            {
                notifyService.Notifiy("video has encoded successufuly"); // Polymorphism
            }
        }
    }
}
