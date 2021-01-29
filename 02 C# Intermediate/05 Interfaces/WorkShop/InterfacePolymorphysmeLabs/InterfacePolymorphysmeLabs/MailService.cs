using System;

namespace InterfacePolymorphysmeLabs
{
    public class MailService : INotifyService
    {
        public void Notifiy(string message)
        {
            Console.WriteLine("Mail:" + message);
        }
    }
}
