using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal abstract class UIFactory
    {
        public abstract Button GetButton(string text);
        public abstract Checkbox GetCheckbox();
    }
}
