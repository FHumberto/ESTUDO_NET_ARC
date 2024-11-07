using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Domain.DTOs;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetList;

public class GetExampleListHandler(IExampleRepository exampleRepository, IMapper mapper) : IRequestHandler<GetExampleListQuery, List<ExampleDto>>
{
    public async Task<List<ExampleDto>> Handle(GetExampleListQuery request, CancellationToken cancellationToken)
    {
        var examples = await exampleRepository.GetAllAsync();

        List<ExampleDto>? data = mapper.Map<List<ExampleDto>>(examples);

        return data;
    }
}