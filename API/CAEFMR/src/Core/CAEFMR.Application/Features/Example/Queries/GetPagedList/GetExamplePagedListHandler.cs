using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Domain.DTOs;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetPagedList;

public class GetExamplePagedListHandler(IExampleRepository exampleRepository, IMapper mapper)
    : IRequestHandler<GetExamplePagedListQuery, List<ExampleDto>>
{
    public async Task<List<ExampleDto>> Handle(GetExamplePagedListQuery request, CancellationToken cancellationToken)
    {
        var examples = await exampleRepository.GetPagedAsync(request.PageNumber, request.PageSize);
        var data = mapper.Map<List<ExampleDto>>(examples);
        return data;
    }
}
