using CAEFMR.Application.Wrappers;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetPagedList;

public class GetExamplePagedListQuery : IRequest<PagedResponse<Domain.DTOs.ExampleDto>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}