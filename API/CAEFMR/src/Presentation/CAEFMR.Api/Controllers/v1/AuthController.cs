using Asp.Versioning;
using CAEFMR.Application.Contracts.Identity;
using CAEFMR.Application.Features.Auth.Login;
using CAEFMR.Application.Features.Auth.Registration;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CAEFMR.Api.Controllers.v1;

[ApiVersion(1)]
public class AuthController(IAuthService authenticationService) : BaseApiController
{
    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerOperation
        (Tags = ["Segurança"],
         Summary = "Realiza o login de um usuário",
         Description = "Este endpoint autentica um usuário com base nas credenciais fornecidas e retorna um token de acesso.")]
    public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
        => Ok(await authenticationService.Login(request));

    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerOperation
        (Tags = ["Segurança"],
         Summary = "Realiza o registro de um novo usuário",
         Description = "Este endpoint cria um novo usuário com as informações fornecidas e retorna uma resposta de registro.")]
    public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
        => Ok(await authenticationService.Register(request));
}
