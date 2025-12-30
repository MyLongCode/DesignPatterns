using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Checkboxes
{
    internal class WindowsCheckbox : Checkbox
    {
        public override void Click() => Console.WriteLine("i'm checkbox on windows =)");
    }
}
