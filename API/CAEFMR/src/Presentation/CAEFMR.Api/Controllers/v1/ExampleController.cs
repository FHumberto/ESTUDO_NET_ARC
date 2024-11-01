using Asp.Versioning;
using CAEFMR.Application.Features.Example.Commands.Create;
using CAEFMR.Application.Features.Example.Commands.Delete;
using CAEFMR.Application.Features.Example.Commands.Update;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CAEFMR.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class ExampleController : BaseApiController
{
    [HttpGet]
    [SwaggerOperation(Summary = "Obter todos os exemplos", Description = "Retorna uma lista de todos os exemplos.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<GetExampleListDto>>> Get()
    {
        List<GetExampleListDto> examples = await Mediator.Send(new GetExampleListQuery());
        return Ok(examples);
    }

    [HttpGet("{id:int}")]
    [SwaggerOperation(Summary = "Obter um exemplo pelo ID", Description = "Retorna um exemplo específico com base no ID fornecido.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GetExampleByIdDto>> GetById(int id)
    {
        GetExampleByIdDto example = await Mediator.Send(new GetExampleByIdQuery(id));
        return Ok(example);
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Criar um novo exemplo", Description = "Cria um novo exemplo com os dados fornecidos.")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(CreateExampleCommand example)
    {
        int response = await Mediator.Send(example);
        return CreatedAtAction(nameof(GetById), new { id = response }, null);
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Atualizar um exemplo", Description = "Atualiza um exemplo existente com base nos dados fornecidos.")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Put(UpdateExampleCommand example)
    {
        await Mediator.Send(example);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    [SwaggerOperation(Summary = "Deletar um exemplo pelo ID", Description = "Remove um exemplo com base no ID fornecido.")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(int id)
    {
        DeleteExampleCommand example = new() { Id = id };
        await Mediator.Send(example);
        return NoContent();
    }
}
