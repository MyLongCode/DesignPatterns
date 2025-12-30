using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstractions
{
    internal abstract class Button
    {
        string Text { get; set; }
        internal Button (string text) { Text = text; }
        public abstract void Click();
        public abstract void Hover();
    }
}
