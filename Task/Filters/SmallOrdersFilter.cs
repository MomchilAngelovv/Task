namespace Task.Filters
{
    public class SmallOrdersFilter : OrderFilter
    {
        public SmallOrdersFilter()
        {
            this.MaxSize = FilterConstants.SmallSize;
        }
    }
}
