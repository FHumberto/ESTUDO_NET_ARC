using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetList;

public record GetExampleListQuery : IRequest<List<Domain.DTOs.ExampleDto>>;
