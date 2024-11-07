using CAEFMR.Application.Exceptions;
using CAEFMR.Application.Interfaces.Repositories;
using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Delete;

public class DeleteExampleHandler(IExampleRepository exampleRepository) : IRequestHandler<DeleteExampleCommand, Unit>
{
    public async Task<Unit> Handle(DeleteExampleCommand request, CancellationToken cancellationToken)
    {
        var exampleToDelete = await exampleRepository.GetByIdAsync(request.Id);

        if (exampleToDelete is null)
        {
            throw new NotFoundException(nameof(Example), request.Id);
        }

        await exampleRepository.DeleteAsync(exampleToDelete);

        return Unit.Value;
    }
}
