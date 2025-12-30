using AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Buttons
{
    internal class LinuxButton : Button
    {
        public LinuxButton(string text) : base(text) {}

        public override void Click() => Console.WriteLine("Click in linux!");

        public override void Hover() => Console.WriteLine("it's linux button");
    }
}
