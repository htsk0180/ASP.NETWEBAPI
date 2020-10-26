namespace OnlineStore.Core.Common.Contracts.ResponseMessages
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
    }
}