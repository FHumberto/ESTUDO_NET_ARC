using CAEFMR.Application.Interfaces.Repositories;
using FluentValidation;

namespace CAEFMR.Application.Features.Example.Commands.Create;

public class CreateExampleValidator : AbstractValidator<CreateExampleCommand>
{
    private readonly IExampleRepository _exampleRepository;

    public CreateExampleValidator(IExampleRepository exampleRepository)
    {
        _exampleRepository = exampleRepository;

        RuleFor(e => e.Nome)
            .MustAsync(ExampleMustNotExist)
            .WithMessage("O exemplo com o Nome '{PropertyValue}' já existe");

        RuleFor(e => e.Nome)
            .NotEmpty().WithMessage("{PropertyName} é obrigatória")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} deve ter até 100 caracteres");

        RuleFor(e => e.Preco)
            .GreaterThan(0).WithMessage("{PropertyName} não pode ser menor do que 0");
    }

    public async Task<bool> ExampleMustNotExist(string nome, CancellationToken token)
    {
        var example = await _exampleRepository.GetExampleByNameAsync(nome);

        // retorna true se o exemplo não existir
        return example is null;
    }
}
