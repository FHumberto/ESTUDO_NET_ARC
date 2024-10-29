using CAEFMR.Application.Features.Example.Queries.GetExampleById;
using CAEFMR.Application.Features.Example.Queries.GetExamplesList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CAEFMR.Api.Controllers.v1;
[Route("api/[controller]")]
[ApiController]
public class ExampleController : ControllerBase
{
    private readonly IMediator _mediator;

    public ExampleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<Example>
    [HttpGet]
    public async Task<List<GetExampleListDto>> Get()
    {
        List<GetExampleListDto>? Examples = await _mediator.Send(new GetExampleListQuery());
        return Examples;
    }

    // GET api/<Example>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<GetExampleByIdDto>> GetById(int id)
    {
        GetExampleByIdDto? Example = await _mediator.Send(new GetExampleByIdQuery(id));
        return Ok(Example);
    }
}