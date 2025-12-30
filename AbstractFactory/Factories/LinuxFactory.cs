using AbstractFactory.Abstractions;
using AbstractFactory.Buttons;
using AbstractFactory.Checkboxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class LinuxFactory : UIFactory
    {
        public override Button GetButton(string text) => new LinuxButton(text);

        public override Checkbox GetCheckbox() => new LinuxCheckbox();
    }
}
