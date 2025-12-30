using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var availableFactories = GetAvailableFactories();
            Console.WriteLine("Available UI types");
            foreach (var factory in availableFactories)
                Console.WriteLine(factory);
            var uiFactory = GetUIFactory("Windows");
            var button = uiFactory.GetButton("Click me!");
            var checkbox = uiFactory.GetCheckbox();
            button.Click();
            checkbox.Click();
        }

        static List<string> GetAvailableFactories()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var factories = assembly.GetTypes()
                .Where(type => type.IsSubclassOf(typeof(UIFactory)) && !type.IsAbstract)
                .ToList();
            return factories.Select(type => type.Name.Replace("Factory", "")).ToList();
        }

        static UIFactory GetUIFactory(string uiFactoryType)
        {
            var factoryName = $"AbstractFactory.Factories.{uiFactoryType}Factory";
            var assembly = Assembly.GetExecutingAssembly();
            Type factoryType = assembly.GetType(factoryName);
            if (factoryType == null) throw new NotSupportedException($"Factory for {uiFactoryType} notification is not found");
            return (UIFactory)Activator.CreateInstance(factoryType);
        }
    }
}
