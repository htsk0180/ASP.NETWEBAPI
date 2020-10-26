using System.Data.Entity;
using OnlineStore.Data.Contracts;
using OnlineStore.Data.Entities;

namespace OnlineStore.Data.Data_Repositories
{
    public class CategoryRepository : RepositoryBase<Category, int>, ICategoryRepository
    {
        public CategoryRepository(DbContext dbContext)
            :base(dbContext)
        {
            
        }
    }
}
