using System.Data.Entity;
using OnlineStore.Data.Contracts;
using OnlineStore.Data.Entities;

namespace OnlineStore.Data.Data_Repositories
{
    public class UserRepository : RepositoryBase<User, int>, IUserRepository
    {
        public UserRepository(DbContext dbContext)
            :base(dbContext)
        {
            
        }
    }
}
