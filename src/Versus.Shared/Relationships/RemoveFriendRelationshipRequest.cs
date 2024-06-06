namespace Versus.Shared.Relationships;

public record RemoveFriendRelationshipRequest
{
    public required Guid Id { get; init; }
}