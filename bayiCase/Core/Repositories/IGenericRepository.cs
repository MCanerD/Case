using System.Linq.Expressions;

namespace Bayi.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression); //IQueryable olduğunda sorgular direkt olarak veritabanına gitmez, farklı sorgu işlemlerinden geçirme imkanı olur.
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
