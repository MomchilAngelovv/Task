namespace Task.Filters
{
    public class BigOrdersFilter : OrderFilter
    {
        public BigOrdersFilter()
        {
            this.MinSize = 10;
            this.MaxSize = 100;
        }
    }
}
