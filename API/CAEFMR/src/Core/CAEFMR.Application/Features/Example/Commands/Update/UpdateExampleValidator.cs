using CAEFMR.Application.Interfaces.Repositories;
using FluentValidation;

namespace CAEFMR.Application.Features.Example.Commands.Update;

public class UpdateExampleValidator : AbstractValidator<UpdateExampleCommand>
{
    private readonly IExampleRepository _exampleRepository;

    public UpdateExampleValidator(IExampleRepository exampleRepository)
    {
        RuleFor(p => p.Id)
            .NotNull()
            .MustAsync(ExampleMustExist);

        RuleFor(e => e.Nome)
            .NotEmpty().WithMessage("{PropertyName} é obrigatória")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} deve ter até 100 caracteres");

        RuleFor(e => e.Preco)
            .GreaterThan(0).WithMessage("{PropertyName} não pode ser menor do que 0");

        _exampleRepository = exampleRepository;
    }

    private async Task<bool> ExampleMustExist(int id, CancellationToken token)
    {
        var example = await _exampleRepository.GetByIdAsync(id);
        return example != null;
    }
}
