namespace OnlineStore.Data.Entities
{
    public class Product : EntityBase<int>
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public virtual Category Category { get; set; }
    }
}
