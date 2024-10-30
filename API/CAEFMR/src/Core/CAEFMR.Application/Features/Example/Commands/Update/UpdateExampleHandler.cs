using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Commands.Update;

public class UpdateExampleHandler : IRequestHandler<UpdateExampleCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IExampleRepository _exampleRepository;

    public UpdateExampleHandler(IMapper mapper, IExampleRepository exampleRepository)
    {
        _mapper = mapper;
        _exampleRepository = exampleRepository;
    }

    public async Task<Unit> Handle(UpdateExampleCommand request, CancellationToken cancellationToken)
    {
        UpdateExampleValidator? validator = new(_exampleRepository);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Any())
            throw new ValidationException(validationResult.Errors);

        var exampleToUpdate = _mapper.Map<Domain.Entities.Example>(request);

        await _exampleRepository.UpdateAsync(exampleToUpdate);

        return Unit.Value;
    }
}