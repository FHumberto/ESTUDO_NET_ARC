using Asp.Versioning;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using Microsoft.AspNetCore.Mvc;

namespace CAEFMR.Api.Controllers.v2;

[ApiVersion(2)]
public class ExampleController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<GetExampleListDto>>> Get()
    {
        List<GetExampleListDto>? examples = await Mediator.Send(new GetExampleListQuery());
        return Ok(examples);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetExampleByIdDto>> GetById(int id)
    {
        GetExampleByIdDto? Example = await Mediator.Send(new GetExampleByIdQuery(id));
        return Ok(Example);
    }
}