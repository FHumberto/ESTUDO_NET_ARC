using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.DTOs;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetPagedList;

public class GetExamplePagedListHandler(IExampleRepository exampleRepository)
    : IRequestHandler<GetExamplePagedListQuery, PagedResponse<ExampleDto>>
{
    public async Task<PagedResponse<ExampleDto>> Handle(GetExamplePagedListQuery request, CancellationToken cancellationToken)
        => await exampleRepository.GetPagedListAsync(request.PageNumber, request.PageSize);
}
