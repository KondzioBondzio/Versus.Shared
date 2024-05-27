namespace Versus.Shared.Relationships;

public record RelationshipResponse
{
    public required Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required RelationshipDirection Direction { get; set; }
    public required int Status { get; set; }
    public required int Type { get; set; }

    public enum RelationshipDirection
    {
        Incoming,
        Outgoing
    }
}