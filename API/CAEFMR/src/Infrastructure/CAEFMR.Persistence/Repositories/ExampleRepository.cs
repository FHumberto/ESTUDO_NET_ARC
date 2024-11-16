using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.DTOs;
using CAEFMR.Domain.Entities;
using CAEFMR.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CAEFMR.Persistence.Repositories;

public class ExampleRepository(AppDbContext context) : GenericRepository<Example>(context), IExampleRepository
{
    public async Task<ExampleDto> GetExampleByNameAsync(string name)
    {
        Example? example = await _context.Examples
            .FirstOrDefaultAsync(p => p.Nome == name);

        return example is null ? null : new ExampleDto(example);
    }

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
