using System.Linq.Expressions;
using WebApplication5.Context;
using WebApplication5.Entity;
using WebApplication5.Interfaces;

namespace WebApplication5.Services
{
    public class GenericRepository<TEntity>(AppDbContext _context) : IGenericRepository<TEntity> where TEntity : Entity.Entity
    {

        //C
        public void Create(TEntity entity)
        {
            _context.Add<TEntity>(entity);

        }

        public async Task CreateAsync(TEntity entity)
        {
            await _context.AddAsync<TEntity>(entity);

        }

        //R
        public IQueryable<TEntity> Read()
        {
            return _context.Set<TEntity>();
        }


        public IQueryable<TEntity> Read(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity Read(int id)
        {
            return _context.Find<TEntity>(id);
        }


        public async Task<TEntity> ReadAsync(int id)
        {
            return await _context.FindAsync<TEntity>(id);
        }



        public bool Update(TEntity entity)
        {
            _context.Update<TEntity>(entity);
            return true;
        }


        public async Task<bool> UpdateAsync(TEntity entity)
        {
            _context.Update<TEntity>(entity);
            await _context.SaveChangesAsync();
            return true;
        }



        public bool Delete(TEntity entity)
        {
            _context.Remove<TEntity>(entity);
            return true;
        }

        public bool Delete(int id)
        {
            _context.Remove<TEntity>(_context.Find<TEntity>(id));
            return true;
        }



    }
}
