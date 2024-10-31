using Asp.Versioning;
using CAEFMR.Application.Features.Example.Commands.Create;
using CAEFMR.Application.Features.Example.Commands.Delete;
using CAEFMR.Application.Features.Example.Commands.Update;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using Microsoft.AspNetCore.Mvc;

namespace CAEFMR.Api.Controllers.v1;

[ApiVersion(1)]
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

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Post(CreateExampleCommand example)
    {
        int response = await Mediator.Send(example);
        return CreatedAtAction(nameof(Get), new { id = response });
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Put(UpdateExampleCommand example)
    {
        await Mediator.Send(example);
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(int id)
    {
        DeleteExampleCommand? example = new() { Id = id };
        await Mediator.Send(example);
        return NoContent();
    }
}