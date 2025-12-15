using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    abstract public class Notification: INotification
    {
        protected string _recipient;

        public string Recipient
        {
            get
            {
                return _recipient;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Recipient cannot be empty");
                }
                _recipient = value;
            }
        }

        protected Notification(string recipient)
        {
            Recipient = recipient;
        }

        protected virtual void ValidateMessage(string message)
        {
            if (string.IsNullOrEmpty(message) || message.Length > 200)
            {
                throw new ArgumentException("Message cannot be empty or more than 200 symbols");
            }
        }

        public abstract void Send(string message);
    }
}
