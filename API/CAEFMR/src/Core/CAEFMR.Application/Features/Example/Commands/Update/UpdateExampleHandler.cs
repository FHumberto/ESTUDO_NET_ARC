using AutoMapper;
using CAEFMR.Application.Exceptions;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Update;

public class UpdateExampleHandler(IMapper mapper, IExampleRepository exampleRepository) : IRequestHandler<UpdateExampleCommand, Unit>
{
    public async Task<Unit> Handle(UpdateExampleCommand request, CancellationToken cancellationToken)
    {
        UpdateExampleValidator validator = new(exampleRepository);

        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count != 0)
        {
            throw new BadRequestException("Exemplo Inválido", validationResult);
        }

        var exampleToUpdate = await exampleRepository.GetByIdAsync(request.Id);

        if (exampleToUpdate is null)
        {
            throw new NotFoundException(nameof(Example), request.Id);
        }

        mapper.Map(request, exampleToUpdate);

        await exampleRepository.UpdateAsync(exampleToUpdate);

        return Unit.Value;
    }
}