namespace Task.Store
{
    using System.Collections.Generic;
    using Task.Models;

    public interface IOrderStore
    {
        IEnumerable<Order> Orders { get; set; }
    }
}
