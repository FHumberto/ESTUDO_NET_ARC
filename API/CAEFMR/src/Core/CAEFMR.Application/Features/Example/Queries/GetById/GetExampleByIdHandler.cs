using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetById;

public class GetExampleByIdHandler(IExampleRepository exampleRepository, IMapper mapper) : IRequestHandler<GetExampleByIdQuery, GetExampleByIdDto>
{
    public async Task<GetExampleByIdDto> Handle(GetExampleByIdQuery request, CancellationToken cancellationToken)
    {
        var example = await exampleRepository.GetByIdAsync(request.Id);

        if (example == null)
        {
            throw new NotImplementedException();
        }

        GetExampleByIdDto? data = mapper.Map<GetExampleByIdDto>(example);

        return data;
    }
}