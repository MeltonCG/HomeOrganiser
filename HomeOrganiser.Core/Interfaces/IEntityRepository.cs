using HomeOrganiser.Core.Entities;

namespace HomeOrganiser.Core.Interfaces
{
    public interface IEntityRepository
    {
        Task<T> Add<T>(T entity) where T : BaseEntity;
        Task AddRange<T>(IEnumerable<T> entities) where T : BaseEntity;
        Task Delete<T>(T entity) where T : BaseEntity;
        Task DeleteRange<T>(IEnumerable<T> entities) where T : BaseEntity;
        Task<T?> GetById<T>(Guid id) where T : BaseEntity;
        Task<IReadOnlyList<T>> ListAll<T>() where T : BaseEntity;
        IQueryable<T> Query<T>() where T : BaseEntity;
        Task Update<T>(T entity) where T : BaseEntity;
        Task UpdateRange<T>(T[] entities) where T : BaseEntity;
        void Dispose();
    }
}