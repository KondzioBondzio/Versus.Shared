namespace Versus.Shared.Rooms;

public record GetRoomRequest
{
    public required Guid Id { get; init; }
}