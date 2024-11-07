using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.DTOs;
using CAEFMR.Domain.Entities;
using CAEFMR.Persistence.Contexts;

namespace CAEFMR.Persistence.Repositories;

public class ExampleRepository(AppDbContext context) : GenericRepository<Example>(context), IExampleRepository
{
    public async Task<PagedResponse<ExampleDto>> GetPagedListAsync(int pageNumber, int pageSize)
    {
        IQueryable<Example> query = _context.Examples
            .OrderBy(p => p.CreatedDate)
            .AsQueryable();

        return await Paged(
            query.Select(p => new ExampleDto(p)),
            pageNumber,
            pageSize);
    }
}
