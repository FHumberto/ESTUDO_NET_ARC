using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Domain.Entities;
using CAEFMR.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Persistence.Repositories;

public class ExampleRepository : GenericRepository<Example>, IExampleRepository
{
    public ExampleRepository(AppDbContext context) : base(context)
    {
    }
}
