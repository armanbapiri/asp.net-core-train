using System.Linq.Expressions;
using WebApplication5.Entity;

namespace WebApplication5.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity.Entity
    {

        public IQueryable<TEntity> Read();

        public IQueryable<TEntity> Read(Expression<Func<TEntity, bool>> predicate);

        public TEntity Read(int id);
        public Task<TEntity> ReadAsync(int id);


        public void Create(TEntity entity);
        public Task CreateAsync(TEntity entity);


        public bool Update(TEntity entity);
        public bool Delete(TEntity entity);
        public bool Delete(int id);




       
    }
}
