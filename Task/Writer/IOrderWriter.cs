namespace Task.Writer
{
    using System.Collections.Generic;

    using Task.Models;

    public interface IOrderWriter
    {
        void WriteOrderInformation(Order order);
        void WriteOrdersInformation(IEnumerable<Order> orders);
    }
}
