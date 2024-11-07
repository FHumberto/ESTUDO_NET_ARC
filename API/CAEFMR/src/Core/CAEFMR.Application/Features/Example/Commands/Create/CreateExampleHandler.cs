using AutoMapper;
using CAEFMR.Application.Exceptions;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Create;

public class CreateExampleHandler(IMapper mapper, IExampleRepository exampleRepository) : IRequestHandler<CreateExampleCommand, int>
{
    public async Task<int> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
    {
        CreateExampleValidator validator = new();

        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count != 0)
        {
            throw new BadRequestException("Exemplo Inválido", validationResult);
        }

        var exampleToCreate = mapper.Map<Domain.Entities.Example>(request);

        await exampleRepository.CreateAsync(exampleToCreate);

        return exampleToCreate.Id;
    }
}