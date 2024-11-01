using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetPagedList;

public class GetExamplePagedListHandler(IExampleRepository exampleRepository, IMapper mapper)
    : IRequestHandler<GetExamplePagedListQuery, List<GetExamplePagedListDto>>
{
    public async Task<List<GetExamplePagedListDto>> Handle(GetExamplePagedListQuery request, CancellationToken cancellationToken)
    {
        var examples = await exampleRepository.GetPagedAsync(request.PageNumber, request.PageSize);
        var data = mapper.Map<List<GetExamplePagedListDto>>(examples);
        return data;
    }
}
