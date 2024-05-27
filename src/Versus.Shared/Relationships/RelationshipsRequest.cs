namespace Versus.Shared.Relationships;

public class RelationshipsRequest
{
    public int? PageNumber { get; set; } = 1;
    public int? PageSize { get; set; } = 10;

    public string OrderBy { get; set; } = "Id";
    public bool OrderByDescending { get; set; }
}