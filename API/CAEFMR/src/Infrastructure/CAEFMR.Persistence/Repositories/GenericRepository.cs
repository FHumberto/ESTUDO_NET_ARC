using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.Entities;
using CAEFMR.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CAEFMR.Persistence.Repositories;

public class GenericRepository<T>(AppDbContext context) : IGenericRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext _context = context;

    public async Task<IReadOnlyList<T>> GetAllAsync()
        => await _context.Set<T>().AsNoTracking().ToListAsync();

    public async Task<IReadOnlyList<T>> GetPagedAsync(int pageNumber, int pageSize)
        => await _context.Set<T>()
                    .AsNoTracking()
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

    public async Task<T?> GetByIdAsync(int id)
        => await _context.Set<T>()
                        .AsNoTracking()
                        .FirstOrDefaultAsync(q => q.Id == id);

    public async Task CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    protected async Task<PagedResponse<TEntity>> Paged<TEntity>(IQueryable<TEntity> query, int pageNumber, int pageSize) where TEntity : class
    {
        int count = await query.CountAsync();

        List<TEntity> pagedResult = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync();

        return new PagedResponse<TEntity>(pagedResult, pageNumber, pageSize, count);
    }
}