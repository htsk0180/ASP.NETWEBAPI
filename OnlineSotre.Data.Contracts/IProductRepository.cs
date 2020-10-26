using OnlineStore.Data.Entities;

namespace OnlineStore.Data.Contracts
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}
