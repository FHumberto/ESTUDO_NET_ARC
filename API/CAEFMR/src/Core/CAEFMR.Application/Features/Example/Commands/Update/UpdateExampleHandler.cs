using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CAEFMR.Application.Features.Example.Commands.Update;

public class UpdateExampleHandler
    (IMapper mapper, IExampleRepository exampleRepository, ILogger<UpdateExampleHandler> logger)
    : IRequestHandler<UpdateExampleCommand, BaseResponse<string>>
{
    public async Task<BaseResponse<string>> Handle(UpdateExampleCommand request, CancellationToken cancellationToken)
    {
        #region ===[ VALIDACAO_DOMINIO ] 

        UpdateExampleValidator validator = new(exampleRepository);

        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count != 0)
        {
            List<Error> errors = validationResult.Errors
                .Select(e => new Error
                    (ErrorCode.ModelStateNotValid, e.ErrorMessage, e.PropertyName))
                .ToList();

            logger.LogWarning("Erro ao atualizar o {Example} - {RequestId}", nameof(Example), request.Id);

            return BaseResponse<string>.Failure(errors);
        }

        #endregion

        #region ===[ MAPPING ]

        var exampleToUpdate = await exampleRepository.GetByIdAsync(request.Id);

        if (exampleToUpdate == null)
        {
            logger.LogWarning("Example with Id {RequestId} not found.", request.Id);

            return BaseResponse<string>.Failure(new Error(ErrorCode.NotFound, "Example not found", nameof(request.Id)));
        }

        mapper.Map(request, exampleToUpdate);

        #endregion

        #region ===[ ACAO_PERSISTIR ]

        await exampleRepository.UpdateAsync(exampleToUpdate);

        #endregion

        #region ===[ RETURN ]

        return BaseResponse<string>.Ok("Exemplo Atualizado.");

        #endregion
    }
}