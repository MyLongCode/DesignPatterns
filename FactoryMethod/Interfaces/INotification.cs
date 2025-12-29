using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces
{
    internal interface INotification
    {
        void SendMessage(string to, string textMessage);
    }
}
