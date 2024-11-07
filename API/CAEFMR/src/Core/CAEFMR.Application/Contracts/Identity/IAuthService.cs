using CAEFMR.Application.Features.Auth.Login;
using CAEFMR.Application.Features.Auth.Registration;

namespace CAEFMR.Application.Contracts.Identity;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest request);
    Task<RegistrationResponse> Register(RegistrationRequest request);
}