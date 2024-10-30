using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Domain.Entities;
using CAEFMR.Persistence.Contexts;

namespace CAEFMR.Persistence.Repositories;

public class ExampleRepository(AppDbContext context) : GenericRepository<Example>(context), IExampleRepository
{
}
