using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.Features.Example.Commands.Delete;

public record DeleteExampleCommand : IRequest<Unit>
{
    public int Id { get; set; }
}