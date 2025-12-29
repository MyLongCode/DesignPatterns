using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }
}
