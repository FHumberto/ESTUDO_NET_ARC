using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetById;

public record GetExampleByIdQuery(int Id) : IRequest<Domain.DTOs.ExampleDto>;