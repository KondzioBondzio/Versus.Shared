namespace Versus.Shared.Auth;

public record RefreshTokenResponse
{
    public required string AccessToken { get; init; }
    public required string RefreshToken { get; init; }
}