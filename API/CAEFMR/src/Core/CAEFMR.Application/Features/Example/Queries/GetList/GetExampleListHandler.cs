using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetList;

public class GetExampleListHandler(IExampleRepository exampleRepository, IMapper mapper) : IRequestHandler<GetExampleListQuery, List<GetExampleListDto>>
{
    public async Task<List<GetExampleListDto>> Handle(GetExampleListQuery request, CancellationToken cancellationToken)
    {
        var examples = await exampleRepository.GetAsync();

        List<GetExampleListDto>? data = mapper.Map<List<GetExampleListDto>>(examples);

        return data;
    }
}