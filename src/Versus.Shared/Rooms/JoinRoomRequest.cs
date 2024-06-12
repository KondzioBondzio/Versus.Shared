namespace Versus.Shared.Rooms;

public record JoinRoomRequest
{
    public string? Password { get; init; }
}