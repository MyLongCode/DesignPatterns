using FactoryMethod.Interfaces;
using FactoryMethod.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class SMSMessageFactory : NotificationFactory
    {
        public override INotification CreateNotification() => new SMSMessage();
    }
}
