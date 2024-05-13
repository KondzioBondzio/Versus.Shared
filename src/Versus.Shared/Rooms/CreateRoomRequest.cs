namespace Versus.Shared.Rooms;

public record CreateRoomRequest
{
    public required string Name { get; set; }
    
    // ...
}