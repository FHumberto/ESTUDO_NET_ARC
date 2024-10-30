using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Create;

public class CreateExampleCommand : IRequest<int>
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
