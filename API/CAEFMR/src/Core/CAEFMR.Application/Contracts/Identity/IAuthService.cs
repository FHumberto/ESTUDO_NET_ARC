using CAEFMR.Application.Features.Auth.Login;
using CAEFMR.Application.Features.Auth.Registration;
using CAEFMR.Application.Wrappers;

namespace CAEFMR.Application.Contracts.Identity;

public interface IAuthService
{
    Task<BaseResponse<AuthResponse>> Login(AuthRequest request);
    Task<BaseResponse<RegistrationResponse>> Register(RegistrationRequest request);
}