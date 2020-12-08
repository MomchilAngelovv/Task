namespace Task.Filters
{
    public class OrderFilter
    {
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public int? MinSize { get; set; }
        public int? MaxSize { get; set; }
        public string Symbol { get; set; }
    }
}
