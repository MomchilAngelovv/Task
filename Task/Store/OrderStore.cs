namespace Task.Store
{
    using System.Collections.Generic;

    using Task.Models;

    public class OrderStore : IOrderStore
    {
        public IEnumerable<Order> Orders { get; set; }

        public OrderStore()
        {
            this.Orders = new List<Order>
            {
                new Order
                {
                    Price = 5,
                    Size = 1,
                    Symbol = "$"
                },
                new Order
                {
                    Price = 500,
                    Size = 15,
                    Symbol = "€"
                },
                new Order
                {
                    Price = 250,
                    Size = 150,
                    Symbol = "€"
                },
            };
        }
    }
}
