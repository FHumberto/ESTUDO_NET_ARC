using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CAEFMR.Application.Features.Example.Commands.Delete;

public class DeleteExampleHandler(IExampleRepository exampleRepository, ILogger<DeleteExampleHandler> logger)
    : IRequestHandler<DeleteExampleCommand, BaseResponse<string>>
{
    public async Task<BaseResponse<string>> Handle(DeleteExampleCommand request, CancellationToken cancellationToken)
    {
        #region ===[ VALIDACAO_EXISTE? ]

        var exampleToDelete = await exampleRepository.GetByIdAsync(request.Id);

        if (exampleToDelete is null)
        {
            logger.LogDebug("Exemplo com ID {Id} encontrado", request.Id);

            return BaseResponse<string>.Failure(new Error(ErrorCode.NotFound, $"Exemplo com o id {request.Id} não encontrado."));
        }

        #endregion

        #region ===[ ACAO_REMOVER ]

        await exampleRepository.DeleteAsync(exampleToDelete);

        #endregion

        #region ===[ RETURN ]

        return BaseResponse<string>.Ok("Exemplo Removido");

        #endregion
    }
}
