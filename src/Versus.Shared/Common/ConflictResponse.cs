using System.Collections;
using System.Text.Json.Serialization;

namespace Versus.Shared.Common;

public record ConflictResponse
{
    [JsonConstructor]
    protected ConflictResponse()
    {
        
    }
    
    public ConflictResponse(string details)
    {
        Details = details;
    }

    public ConflictResponse(string details, IEnumerable<ConflictDetail> errors)
    {
        Details = details;
        Errors = errors;
    }

    public string Details { get; init; } = null!;
    public IEnumerable<ConflictDetail> Errors { get; init; } = [];
}

public record ConflictDetail
{
    [JsonConstructor]
    public ConflictDetail()
    {
        
    }

    public ConflictDetail(string resourceType, string resourceIds, string description)
    {
        ResourceType = resourceType;
        ResourceIds = resourceIds;
        Description = description;
    }

    public string ResourceType { get; init; } = null!;
    public string ResourceIds { get; init; } = null!;
    public string Description { get; init; } = null!;

    public static ConflictDetail FromResource<TResourceType, TResourceId>(TResourceId resourceId, string description)
        where TResourceType : class
    {
        return new ConflictDetail(typeof(TResourceType).Name, resourceId!.ToString()!, description);
    }

    public static ConflictDetail FromResource<TResourceType>(IEnumerable resourceIds, string description)
        where TResourceType : class
    {
        return FromResource<TResourceType, string>(string.Join(",", resourceIds), description);
    }
}