using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public class SmsNotification(string recipient) : Notification(recipient)
    {
        public override void Send(string message)
        {
            ValidateMessage(message);
            Console.WriteLine($"Sms to {Recipient}: {message}");
        }
    }
}
