using CAEFMR.Domain.Entities;

namespace CAEFMR.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    //? IReadOnlyList para ser imutável
    Task<IReadOnlyList<T>> GetAsync();
    Task<IReadOnlyList<T>> GetPagedAsync(int pageNumber, int pageSize);
    Task<T?> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
