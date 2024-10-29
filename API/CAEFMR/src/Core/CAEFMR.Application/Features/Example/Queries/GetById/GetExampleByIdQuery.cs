using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetExampleById;

public record GetExampleByIdQuery(int Id) : IRequest<GetExampleByIdDto>;