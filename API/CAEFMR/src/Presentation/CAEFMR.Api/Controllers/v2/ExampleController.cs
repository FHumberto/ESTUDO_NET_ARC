using Asp.Versioning;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CAEFMR.Api.Controllers.v2;

[ApiVersion(2)]
public class ExampleController : BaseApiController
{
    [HttpGet]
    [SwaggerOperation(Summary = "Obter todos os exemplos", Description = "Retorna uma lista de todos os exemplos.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<GetExampleListDto>>> Get()
    {
        List<GetExampleListDto>? examples = await Mediator.Send(new GetExampleListQuery());
        return Ok(examples);
    }

    [HttpGet("{id:int}")]
    [SwaggerOperation(Summary = "Obter um exemplo pelo ID", Description = "Retorna um exemplo específico com base no ID fornecido.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GetExampleByIdDto>> GetById(int id)
    {
        GetExampleByIdDto? example = await Mediator.Send(new GetExampleByIdQuery(id));
        return Ok(example);
    }
}