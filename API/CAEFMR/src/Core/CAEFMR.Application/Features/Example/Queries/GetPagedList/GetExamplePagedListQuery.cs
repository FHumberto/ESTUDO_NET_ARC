using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetPagedList;

public class GetExamplePagedListQuery : IRequest<List<GetExamplePagedListDto>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}