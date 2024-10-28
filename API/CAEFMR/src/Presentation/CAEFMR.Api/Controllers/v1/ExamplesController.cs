using CAEFMR.Application.Features.Example.Queries.GetExampleById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CAEFMR.Api.Controllers.v1;
[Route("api/[controller]")]
[ApiController]
public class ExamplesController : ControllerBase
{
    private readonly IMediator _mediator;

    public ExamplesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET api/<ExamplesController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<GetExampleByIdDto>> GetById(int id)
    {
        GetExampleByIdDto? Example = await _mediator.Send(new GetExampleByIdQuery(id));
        return Ok(Example);
    }
}