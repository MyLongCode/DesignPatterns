using System.Reflection;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            var availableFactories = GetAvailableFactories();
            Console.WriteLine("Available notification types");
            foreach(var factory in availableFactories)
                Console.WriteLine(factory);
            var notificationFactory = GetNotificationFactory("Email");
            var notification = notificationFactory.CreateNotification();
            notification.SendMessage("mylongcode", "hello, it's your email notification");
        }


        static List<string> GetAvailableFactories()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var factories = assembly.GetTypes()
                .Where(type => type.IsSubclassOf(typeof(NotificationFactory)) && !type.IsAbstract)
                .ToList();
            return factories.Select(type => type.Name.Replace("NotificationFactory", "")).ToList();
        }

        static NotificationFactory GetNotificationFactory(string notificationType)
        {
            var factoryName = $"FactoryMethod.Factories.{notificationType}MessageFactory";
            var assembly = Assembly.GetExecutingAssembly();
            Type factoryType = assembly.GetType(factoryName);
            if (factoryType == null) throw new NotSupportedException($"Factory for {notificationType} notification is not found");
            return (NotificationFactory)Activator.CreateInstance(factoryType);
        }
    }
}
