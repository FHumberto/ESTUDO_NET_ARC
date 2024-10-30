﻿using MediatR;

namespace CAEFMR.Application.Features.Example.Commands.Update;

public class UpdateExampleCommand : IRequest<Unit>
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
