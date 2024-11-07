namespace CAEFMR.Application.Features.Auth.Login;

public class AuthRequest
{
    public required string Email { get; set; }
    public required string Password { get; set; }
}
