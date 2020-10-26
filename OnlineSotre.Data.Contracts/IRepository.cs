using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineStore.Data.Contracts
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class
    {
        Task<TEntity> GetAsync(TKey id);
        IQueryable<TEntity> GetAll(int skip, int take);
        IQueryable<TEntity> GetAll(int skip, int take, Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void Update(TEntity entity);
        Task Delete(TKey id);
        void Delete(TEntity entity);
        Task SaveChangeAsync();
    }
}
