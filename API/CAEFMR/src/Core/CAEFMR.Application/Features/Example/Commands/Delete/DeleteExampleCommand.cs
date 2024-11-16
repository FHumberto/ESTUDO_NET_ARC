using CAEFMR.Application.Wrappers;
using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Delete;

//?  ENTRA ==> : <== VOLTA
public record DeleteExampleCommand(int Id) : IRequest<BaseResponse<string>>;