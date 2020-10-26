namespace OnlineStore.Core.Common.Contracts.RequestMessages
{
    public class ProductSearchRequest
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public string ProductName { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}