using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Notifications
{
    internal class SMSMessage : INotification
    {
        public void SendMessage(string to, string textMessage)
        {
            Console.Write($"Sent SMS message to {to}, with text {textMessage}");
        }
    }
}
