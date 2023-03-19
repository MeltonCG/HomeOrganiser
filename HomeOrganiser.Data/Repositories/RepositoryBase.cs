using HomeOrganiser.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeOrganiser.Data.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly ApplicationDbContext _dbContext;

        public RepositoryBase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Query<T>() where T : BaseEntity
        {
                return _dbContext.Set<T>();
        }

        public async Task<T?> GetById<T>(Guid id) where T : BaseEntity
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAll<T>() where T : BaseEntity
        {
            return await _dbContext.Set<T>().ToListAsync();
        }


        public async Task<T> Add<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task AddRange<T>(IEnumerable<T> entities) where T : BaseEntity
        {
            _dbContext.Set<T>().AddRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update<T>(T entity) where T : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateRange<T>(T[] entities) where T : BaseEntity
        {
            _dbContext.Set<T>().UpdateRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteRange<T>(IEnumerable<T> entities) where T : BaseEntity
        {
            _dbContext.Set<T>().RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }
    }
}
