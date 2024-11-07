using System;

namespace Dependency_Inversion_Principle
{
    // Abstraction

    public interface INotificationService
    {
        void Notify(string message);
    }

    // Low-level module (Email Notification)

    public class EmailNotificationService : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    // High-level module

    public class OrderProcessor
    {
        private readonly INotificationService _notificationService;

        // Dependency Injection through constructor

        public OrderProcessor(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void ProcessOrder(string orderDetails)
        {
            Console.WriteLine("Processing Order: " + orderDetails);
            _notificationService.Notify("Order processed successfully!");
        }
    }

    // Client code

    internal class Dependency_Inversion_Principle
    {
        static void Main(string[] args)
        {
            INotificationService notificationService = new EmailNotificationService();
            OrderProcessor orderProcessor = new OrderProcessor(notificationService);

            orderProcessor.ProcessOrder("Order #12345");
        }
    }
}

