using CAEFMR.Application.Contracts.Identity;
using CAEFMR.Application.Features.Auth.Login;
using CAEFMR.Application.Features.Auth.Registration;
using CAEFMR.Application.Settings;
using CAEFMR.Application.Wrappers;
using CAEFMR.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace CAEFMR.Identity.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly JwtSettings _jwtSettings;

    public AuthService(UserManager<ApplicationUser> userManager,
        IOptions<JwtSettings> jwtSettings,
        SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _jwtSettings = jwtSettings.Value;
        _signInManager = signInManager;
    }

    public async Task<BaseResponse<AuthResponse>> Login(AuthRequest request)
    {
        ApplicationUser? user = await _userManager.FindByEmailAsync(request.Email);

        if (user == null)
        {
            return BaseResponse<AuthResponse>.Failure(new Error(ErrorCode.NotFound, "Usuário não encontrado.", request.Email));
        }

        SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

        if (!result.Succeeded)
        {
            return BaseResponse<AuthResponse>.Failure(new Error(ErrorCode.BadRequest, $"Credênciais Inválidas."));
        }

        JwtSecurityToken jwtSecurityToken = await GenerateToken(user);

        AuthResponse? response = new()
        {
            Id = user.Id,
            Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
            Email = user.Email ?? string.Empty,
            UserName = user.UserName ?? string.Empty
        };

        return BaseResponse<AuthResponse>.Ok(response);
    }

    public async Task<BaseResponse<RegistrationResponse>> Register(RegistrationRequest request)
    {
        ApplicationUser? user = new()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            UserName = request.UserName,
            EmailConfirmed = true
        };

        IdentityResult? result = await _userManager.CreateAsync(user, request.Password);

        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, "Employee");
            return new RegistrationResponse() { UserId = user.Id };
        }
        else
        {
            StringBuilder str = new();

            foreach (IdentityError err in result.Errors)
            {
                str.AppendFormat("•{0}\n", err.Description);
            }

            return BaseResponse<RegistrationResponse>.Failure(new Error(ErrorCode.BadRequest, $"{str}"));
        }
    }

    private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
    {
        IList<Claim> userClaims = await _userManager.GetClaimsAsync(user);
        IList<string> roles = await _userManager.GetRolesAsync(user);

        List<Claim> roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();

        IEnumerable<Claim> claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim("uid", user.Id)
        }
        .Union(userClaims)
        .Union(roleClaims);

        SymmetricSecurityKey symmetricSecurityKey = new(Encoding.UTF8.GetBytes(_jwtSettings.Key));

        SigningCredentials signingCredentials = new(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        JwtSecurityToken jwtSecurityToken = new(
           issuer: _jwtSettings.Issuer,
           audience: _jwtSettings.Audience,
           claims: claims,
           expires: DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes),
           signingCredentials: signingCredentials);
        return jwtSecurityToken;
    }

}
