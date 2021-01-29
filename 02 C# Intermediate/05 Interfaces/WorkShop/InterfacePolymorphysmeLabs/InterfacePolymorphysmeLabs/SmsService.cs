using System;

namespace InterfacePolymorphysmeLabs
{
    public class SmsService : INotifyService
    {
        public void Notifiy(string message)
        {
            Console.WriteLine("SMS:" + message);
        }
    }
}
