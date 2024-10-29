using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Queries.GetExamplesList;

public record GetExampleListQuery() : IRequest<List<GetExampleListDto>>;
