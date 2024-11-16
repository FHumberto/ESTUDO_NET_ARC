using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.DTOs;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CAEFMR.Application.Features.Example.Queries.GetById;

public class GetExampleByIdHandler
    (IExampleRepository exampleRepository, IMapper mapper, ILogger<GetExampleByIdHandler> logger)
    : IRequestHandler<GetExampleByIdQuery, BaseResponse<ExampleDto>>
{

    public async Task<BaseResponse<ExampleDto>> Handle(GetExampleByIdQuery request, CancellationToken cancellationToken)
    {
        #region ===[ VALIDACAO_EXISTE? ]

        var example = await exampleRepository.GetByIdAsync(request.Id);

        if (example is null)
        {
            logger.LogDebug("Exemplo com ID {Id} encontrado", request.Id);

            return BaseResponse<ExampleDto>
                .Failure(new Error(ErrorCode.NotFound, $"Exemplo com o id {request.Id} não encontrado."));
        }

        #endregion

        #region ===[ MAPPING ]

        ExampleDto? data = mapper.Map<ExampleDto>(example);

        #endregion

        #region ===[ RETURN ]

        return BaseResponse<ExampleDto>.Ok(data);

        #endregion
    }
}
