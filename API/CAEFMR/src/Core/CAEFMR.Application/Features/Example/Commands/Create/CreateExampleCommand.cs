using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Commands.Create;

public class CreateExampleCommand : IRequest<int>
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
