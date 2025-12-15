using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    abstract class Notification: INotification
    {
        protected string _recipient;

        public string Recipient
        {
            get
            {
                return _recipient;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _recipient = value;
                }
            }
        }

        protected Notification(string recipient)
        {
            Recipient = recipient;
        }

        protected static void ValidateMessage(string message)
        {
            if (string.IsNullOrEmpty(message) || message.Length > 200)
            {
                Console.WriteLine($"{message} --- validation error");
            }
        }

        public abstract void Send(string message);
    }
}
