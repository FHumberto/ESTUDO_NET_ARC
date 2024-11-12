using Asp.Versioning;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using CAEFMR.Application.Features.Example.Queries.GetPagedList;
using CAEFMR.Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CAEFMR.Api.Controllers.v2;

[ApiVersion("2")]
[Authorize(Roles = "Administrator")]
public class ExampleController : BaseApiController
{
    [HttpGet]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Obter todos os exemplos", Description = "Retorna uma lista de todos os exemplos.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<ExampleDto>>> Get()
    {
        List<ExampleDto> examples = await Mediator.Send(new GetExampleListQuery());
        return Ok(examples);
    }

    [HttpGet("{id:int}")]
    [SwaggerOperation(Summary = "Obter um exemplo pelo ID", Description = "Retorna um exemplo específico com base no ID fornecido.")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ExampleDto>> GetById(int id)
    {
        ExampleDto example = await Mediator.Send(new GetExampleByIdQuery(id));
        return Ok(example);
    }

    [AllowAnonymous]
    [HttpGet("paged")]
    [SwaggerOperation(Summary = "Obter lista paginada de exemplos", Description = "Retorna uma lista paginada de exemplos.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPagedList([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        var query = new GetExamplePagedListQuery { PageNumber = pageNumber, PageSize = pageSize };
        var examples = await Mediator.Send(query);
        return Ok(examples);
    }
}