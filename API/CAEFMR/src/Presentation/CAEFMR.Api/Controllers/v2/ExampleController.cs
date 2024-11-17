using Asp.Versioning;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using CAEFMR.Application.Features.Example.Queries.GetPagedList;
using CAEFMR.Application.Wrappers;
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
    public async Task<BaseResponse<List<ExampleDto>>> Get()
        => await Mediator.Send(new GetExampleListQuery());

    [HttpGet("{id:int}")]
    [SwaggerOperation(Summary = "Obter um exemplo pelo ID", Description = "Retorna um exemplo específico com base no ID fornecido.")]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<BaseResponse<ExampleDto>> GetById(int id)
        => await Mediator.Send(new GetExampleByIdQuery(id));

    [AllowAnonymous]
    [HttpGet("paged")]
    [SwaggerOperation(Summary = "Obter lista paginada de exemplos", Description = "Retorna uma lista paginada de exemplos.")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<PagedResponse<ExampleDto>> GetPagedList([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        GetExamplePagedListQuery query = new() { PageNumber = pageNumber, PageSize = pageSize };
        return await Mediator.Send(query);
    }
}