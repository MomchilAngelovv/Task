namespace Task.Writer
{
    using System;
    using System.Collections.Generic;

    using Task.Models;

    public class OrderWriter : IOrderWriter
    {
        public void WriteOrderInformation(Order order)
        {
            Console.WriteLine($"Symbol:{order.Symbol} Size:{order.Size} Price:{order.Price}");
        }

        public void WriteOrdersInformation(IEnumerable<Order> orders)
        {
            foreach (var order in orders)
            {
                WriteOrderInformation(order);
            }
        }
    }
}
