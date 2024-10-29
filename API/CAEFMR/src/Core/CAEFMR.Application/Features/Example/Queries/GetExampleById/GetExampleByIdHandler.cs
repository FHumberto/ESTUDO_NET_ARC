using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetExampleById;

public class GetExampleByIdHandler : IRequestHandler<GetExampleByIdQuery, GetExampleByIdDto>
{
    #region Propriedades

    private readonly IExampleRepository _exampleRepository;
    private readonly IMapper _mapper;

    #endregion

    #region Construtores

    public GetExampleByIdHandler(IExampleRepository exampleRepository, IMapper mapper)
    {
        _exampleRepository = exampleRepository;
        _mapper = mapper;
    }

    #endregion

    public async Task<GetExampleByIdDto> Handle(GetExampleByIdQuery request, CancellationToken cancellationToken)
    {
        #region 01. Existe?

        var example = await _exampleRepository.GetByIdAsync(request.Id);

        #endregion

        #region 2. Tratamento de Erro

        if (example == null)
            throw new NotImplementedException();

        #endregion

        #region 03. Mapeamento

        GetExampleByIdDto? data = _mapper.Map<GetExampleByIdDto>(example);

        #endregion

        #region retorno
        
        return data;
        
        #endregion
    }
}