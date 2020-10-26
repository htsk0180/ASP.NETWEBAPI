namespace OnlineStore.Core.Common.Contracts.RequestMessages
{
    public class ProductCreateRequest
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
    }
}
