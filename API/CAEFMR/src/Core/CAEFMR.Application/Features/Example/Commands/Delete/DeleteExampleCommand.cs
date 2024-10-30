using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Delete;

public record DeleteExampleCommand : IRequest<Unit>
{
    public int Id { get; set; }
}