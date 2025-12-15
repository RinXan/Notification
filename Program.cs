using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            List<INotification> notifications =
            [
                new EmailNotification("funnyZiliya@gmail.com"),
                new PushNotification("Zilliya"),
                new SmsNotification("+475318962"),
            ];

            foreach (var notification in notifications)
            {
                notification.Send("Hello, invite you to my 17th birthday on friday evening!");
            }
        }
    }
}
