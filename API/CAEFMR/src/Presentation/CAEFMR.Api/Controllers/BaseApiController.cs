using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CAEFMR.Api.Controllers;

[ApiController]
[Route("api/v{v:apiVersion}/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    private IMediator? _mediator;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
}
