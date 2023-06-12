namespace Elsa.Api.Client.Resources.ActivityDescriptors.Models;

/// <summary>
/// A descriptor of an activity type.
/// </summary>
public record ActivityDescriptor
{
    /// <summary>
    /// The fully qualified name of the activity type.
    /// </summary>
    public string TypeName { get; init; } = default!;

    /// <summary>
    /// The namespace of the activity type.
    /// </summary>
    public string Namespace { get; init; } = default!;
    
    /// <summary>
    /// The name of the activity type.
    /// </summary>
    public string Name { get; init; } = default!;
    
    /// <summary>
    /// The version of the activity type.
    /// </summary>
    public int Version { get; init; }
    
    /// <summary>
    /// The category of the activity type.
    /// </summary>
    public string Category { get; init; } = default!;
    
    /// <summary>
    /// The display name of the activity type.
    /// </summary>
    public string? DisplayName { get; init; }
    
    /// <summary>
    /// The description of the activity type.
    /// </summary>
    public string? Description { get; init; }
    
    /// <summary>
    /// The input properties of the activity type.
    /// </summary>
    public ICollection<InputDescriptor> Inputs { get; init; } = new List<InputDescriptor>();
    
    /// <summary>
    /// The output properties of the activity type.
    /// </summary>
    public ICollection<OutputDescriptor> Outputs { get; init; } = new List<OutputDescriptor>();

    /// <summary>
    /// The kind of activity.
    /// </summary>
    public ActivityKind Kind { get; set; } = ActivityKind.Action;
    
    /// <summary>
    /// The ports of the activity type.
    /// </summary>
    public ICollection<Port> Ports { get; init; } = new List<Port>();
    
    /// <summary>
    /// The custom properties of the activity type.
    /// </summary>
    public IDictionary<string, object> CustomProperties { get; set; } = new Dictionary<string, object>();

    /// <summary>
    /// A value indicating whether this activity is a container of child activities.
    /// </summary>
    public bool IsContainer { get; set; }

    /// <summary>
    /// Whether this activity type is selectable from activity pickers.
    /// </summary>
    public bool IsBrowsable { get; set; }
}