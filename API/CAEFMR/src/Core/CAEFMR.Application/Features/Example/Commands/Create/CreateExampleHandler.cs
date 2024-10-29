using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Commands.Create;

public class CreateExampleHandler : IRequestHandler<CreateExampleCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IExampleRepository _exampleRepository;

    public CreateExampleHandler(IMapper mapper, IExampleRepository exampleRepository)
    {
        _mapper = mapper;
        _exampleRepository = exampleRepository;
    }

    public async Task<int> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
    {
        CreateExampleValidator? validator = new();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Any())
            throw new ValidationException(validationResult.Errors);

        var exampleToCreate = _mapper.Map<Domain.Entities.Example>(request);

        await _exampleRepository.CreateAsync(exampleToCreate);

        return exampleToCreate.Id;
    }
}