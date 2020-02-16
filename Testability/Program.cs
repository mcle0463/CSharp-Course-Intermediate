using System;

namespace Testability
{
    class Program
    {
        static void Main()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
            Console.WriteLine("Hello World!");
        }
    }
}
