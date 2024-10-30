using AutoMapper;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Commands.Delete;

public class DeleteExampleHandler : IRequestHandler<DeleteExampleCommand, Unit>
{
    private readonly IExampleRepository _exampleRepository;

    public DeleteExampleHandler(IExampleRepository exampleRepository)
    {
        _exampleRepository = exampleRepository;
    }

    public async Task<Unit> Handle(DeleteExampleCommand request, CancellationToken cancellationToken)
    {
        var exampleToDelete = await _exampleRepository.GetByIdAsync(request.Id);

        if (exampleToDelete is null)
            throw new NotImplementedException();

        await _exampleRepository.DeleteAsync(exampleToDelete);

        return Unit.Value;
    }
}
