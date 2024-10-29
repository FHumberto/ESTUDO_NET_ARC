using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Commands.Create;

public class CreateExampleValidator : AbstractValidator<CreateExampleCommand>
{
    public CreateExampleValidator()
    {
        RuleFor(e => e.Nome)
            .NotEmpty().WithMessage("{PropertyName} é obrigatória")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} deve ter até 100 caracteres");

        RuleFor(e => e.Preco)
            .GreaterThan(0).WithMessage("{PropertyName} não pode ser menor do que 0");
    }
}
