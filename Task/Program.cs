namespace Task
{
    using Task.Store;
    using Task.Writer;
    using Task.Filters;
    using Task.Service;

    public class Program
    {
        static void Main(string[] args)
        {
            var orderWriter = new OrderWriter();
            var orderStore = new OrderStore();
            var orderService = new OrderService(orderStore);

            var filter = new BigOrdersFilter();
            var orders = orderService.GetOrdersByFilter(filter);

            var customFilter = new OrderFilter
            {
                MinPrice = 50,
                MaxPrice = 400
            };

            var ordersByCustomFilter = orderService.GetOrdersByFilter(customFilter);
            orderWriter.WriteOrdersInformation(orders);
            orderWriter.WriteOrdersInformation(ordersByCustomFilter);
        }
    }
}
