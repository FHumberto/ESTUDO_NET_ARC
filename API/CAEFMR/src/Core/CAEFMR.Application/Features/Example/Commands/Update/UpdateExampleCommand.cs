using CAEFMR.Application.Wrappers;
using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Update;

//?  ENTRA ==> : <== VOLTA
public class UpdateExampleCommand : IRequest<BaseResponse<string>>
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
