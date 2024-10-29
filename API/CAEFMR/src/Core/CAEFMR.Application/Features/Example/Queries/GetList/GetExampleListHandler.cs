using AutoMapper;
using CAEFMR.Application.Features.Example.Queries.GetExampleById;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Queries.GetExamplesList;

public class GetExampleListHandler : IRequestHandler<GetExampleListQuery, List<GetExampleListDto>>
{
    #region Propriedades

    private readonly IExampleRepository _exampleRepository;
    private readonly IMapper _mapper;

    #endregion

    #region Construtores

    public GetExampleListHandler(IExampleRepository exampleRepository, IMapper mapper)
    {
        _exampleRepository = exampleRepository;
        _mapper = mapper;
    }

    #endregion

    public async Task<List<GetExampleListDto>> Handle(GetExampleListQuery request, CancellationToken cancellationToken)
    {
        var examples = await _exampleRepository.GetAsync();

        List<GetExampleListDto>? data = _mapper.Map<List<GetExampleListDto>>(examples);

        return data;
    }
}