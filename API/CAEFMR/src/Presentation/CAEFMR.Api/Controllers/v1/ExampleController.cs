using Asp.Versioning;
using CAEFMR.Application.Features.Example.Commands.Create;
using CAEFMR.Application.Features.Example.Commands.Delete;
using CAEFMR.Application.Features.Example.Commands.Update;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CAEFMR.Api.Controllers.v1;

[ApiVersion("1")]
[Authorize(Roles = "Administrator")]
public class ExampleController : BaseApiController
{
    [HttpGet]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Obter todos os exemplos", Description = "Retorna uma lista de todos os exemplos.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<BaseResponse<List<ExampleDto>>> Get()
        => await Mediator.Send(new GetExampleListQuery());

    [HttpGet("{id:int}")]
    [SwaggerOperation(Summary = "Obter um exemplo pelo ID", Description = "Retorna um exemplo específico com base no ID fornecido.")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<BaseResponse<ExampleDto>> GetById(int id)
        => await Mediator.Send(new GetExampleByIdQuery(id));

    [HttpPost]
    [SwaggerOperation(Summary = "Criar um novo exemplo", Description = "Cria um novo exemplo com os dados fornecidos.")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<BaseResponse<int>> Post(CreateExampleCommand example)
       => await Mediator.Send(example);

    [HttpPut]
    [SwaggerOperation(Summary = "Atualizar um exemplo", Description = "Atualiza um exemplo existente com base nos dados fornecidos.")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<BaseResponse> Put(UpdateExampleCommand example)
        => await Mediator.Send(example);

    [HttpDelete("{id:int}")]
    [SwaggerOperation(Summary = "Deletar um exemplo pelo ID", Description = "Remove um exemplo com base no ID fornecido.")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<BaseResponse> Delete(int id)
        => await Mediator.Send(new DeleteExampleCommand(id));
}
