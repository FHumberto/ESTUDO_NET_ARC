using CAEFMR.Application.Wrappers;
using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Create;

//?  ENTRA ==> : <== VOLTA
public class CreateExampleCommand : IRequest<BaseResponse<int>>
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
