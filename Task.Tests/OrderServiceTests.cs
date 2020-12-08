namespace Task.Tests
{
    using System.Linq;

    using Xunit;

    using Task.Store;
    using Task.Filters;
    using Task.Service;

    public class OrderServiceTests
    {
        private readonly OrderStore orderStore;

        public OrderServiceTests()
        {
            this.orderStore = new OrderStore();
        }

        [Fact]
        public void BigOrdersFilterShuoldReturn1Element()
        {
            var orderService = new OrderService(orderStore);

            var filter = new BigOrdersFilter();
            var orders = orderService.GetOrdersByFilter(filter);

            Assert.Single(orders);

            var order = orders.First();

            Assert.Equal("ˆ", order.Symbol);
            Assert.Equal(15, order.Size);
        }

        [Fact]
        public void SmallOrdersFilterShuoldReturn1Element()
        {
            var orderService = new OrderService(orderStore);

            var filter = new SmallOrdersFilter();
            var orders = orderService.GetOrdersByFilter(filter);

            Assert.Single(orders);
        }

        [Fact]
        public void CustomOrdersFilterShuoldReturn2ElementsWithEuroSymbol()
        {
            var orderService = new OrderService(orderStore);

            var filter = new OrderFilter
            {
                Symbol = "ˆ"
            };

            var orders = orderService.GetOrdersByFilter(filter);
            Assert.Equal(2, orders.Count());
        }

        [Fact]
        public void CustomOrdersFilterShuoldReturn1ElementWithEuroSymbolAndSizeGreaterThan120()
        {
            var orderService = new OrderService(orderStore);

            var filter = new OrderFilter
            {
                MinSize = 120,
                Symbol = "ˆ"
            };

            var orders = orderService.GetOrdersByFilter(filter);
            Assert.Single(orders);
        }
    }
}
