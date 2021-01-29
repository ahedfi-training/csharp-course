using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphysmeLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var smsService = new SmsService();
            var mailService = new MailService();

            var notifiyServices = new INotifyService[] { smsService, mailService };
            var videoEncoder = new VideoEncoder(notifiyServices);

            videoEncoder.Encode(new Video());
        }
    }
}
