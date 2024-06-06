namespace Versus.Shared.Rooms;

public record JoinRoomRequest
{
    public required Guid Id { get; init; }
}