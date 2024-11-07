using AutoMapper;
using CAEFMR.Application.Exceptions;
using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Domain.DTOs;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetById;

public class GetExampleByIdHandler(IExampleRepository exampleRepository, IMapper mapper) : IRequestHandler<GetExampleByIdQuery, ExampleDto>
{
    public async Task<ExampleDto> Handle(GetExampleByIdQuery request, CancellationToken cancellationToken)
    {
        var example = await exampleRepository.GetByIdAsync(request.Id);

        if (example is null)
        {
            throw new NotFoundException(nameof(Example), request.Id);
        }

        ExampleDto? data = mapper.Map<ExampleDto>(example);

        return data;
    }
}