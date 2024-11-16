using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.DTOs;
using CAEFMR.Domain.Entities;

namespace CAEFMR.Application.Interfaces.Repositories;

public interface IExampleRepository : IGenericRepository<Example>
{
    Task<ExampleDto> GetExampleByNameAsync(string name);
    Task<PagedResponse<ExampleDto>> GetPagedListAsync(int pageNumber, int pageSize);
}
