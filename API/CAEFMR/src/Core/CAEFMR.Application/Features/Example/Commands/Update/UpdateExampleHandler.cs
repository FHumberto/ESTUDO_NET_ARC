using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using FluentValidation;
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
            throw new ValidationException(validationResult.Errors);
        }

        var exampleToUpdate = mapper.Map<Domain.Entities.Example>(request);

        await exampleRepository.UpdateAsync(exampleToUpdate);

        return Unit.Value;
    }
}