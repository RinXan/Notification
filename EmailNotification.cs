using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    internal class EmailNotification(string recipient) : Notification(recipient)
    {
        public override void Send(string message)
        {
            ValidateMessage(message);
            Console.WriteLine($"Email to {Recipient}: {message}");
        }
    }
}
