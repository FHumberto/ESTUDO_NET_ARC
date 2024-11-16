using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Create;

public class CreateExampleHandler(IMapper mapper, IExampleRepository exampleRepository) : IRequestHandler<CreateExampleCommand, BaseResponse<int>>
{
    public async Task<BaseResponse<int>> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
    {
        #region ===[ VALIDACAO_DOMINIO ] 

        CreateExampleValidator validator = new(exampleRepository);

        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count != 0)
        {
            List<Error> errors = validationResult.Errors
                .Select(e => new Error
                    (ErrorCode.ModelStateNotValid, e.ErrorMessage, e.PropertyName))
                .ToList();

            return BaseResponse<int>.Failure(errors);
        }

        #endregion

        #region ===[ MAPPING ]

        var exampleToCreate = mapper.Map<Domain.Entities.Example>(request);

        #endregion

        #region ===[ ACAO_PERSISTIR ]

        await exampleRepository.CreateAsync(exampleToCreate);

        #endregion

        #region ===[ RETURN ]

        return BaseResponse<int>.Ok(exampleToCreate.Id);

        #endregion
    }
}
