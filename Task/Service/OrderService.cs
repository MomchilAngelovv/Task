namespace Task.Service
{
    using System.Linq;
    using System.Collections.Generic;

    using Task.Store;
    using Task.Models;
    using Task.Filters;

    public class OrderService
    {
        private readonly IOrderStore orderStore;

        public OrderService(IOrderStore orderStore)
        {
            this.orderStore = orderStore;
        }

        public IEnumerable<Order> GetOrdersByFilter(OrderFilter filter = null)
        {
            var orders = orderStore.Orders;

            if (filter != null)
            {
                if (filter.MinPrice != null)
                {
                    orders = orders.Where(o => o.Price >= filter.MinPrice);
                }

                if (filter.MaxPrice != null)
                {
                    orders = orders.Where(o => o.Price <= filter.MaxPrice);
                }

                if (filter.MinSize != null)
                {
                    orders = orders.Where(o => o.Size >= filter.MinSize);
                }

                if (filter.MaxSize != null)
                {
                    orders = orders.Where(o => o.Size <= filter.MaxSize);
                }

                if (filter.Symbol != null)
                {
                    orders = orders.Where(o => o.Symbol == filter.Symbol);
                }
            }

            return orders;
        }
    }
}
