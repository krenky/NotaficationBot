using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class GitStatus
{
    //
    // Сводка:
    //     Status identifier.
    [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int Id { get; set; }

    //
    // Сводка:
    //     State of the status.
    [JsonProperty( PropertyName = "state", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public GitStatusState State { get; set; }

    //
    // Сводка:
    //     Status description. Typically describes current state of the status.
    [JsonProperty( PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Description { get; set; }

    //
    // Сводка:
    //     Context of the status.
    [JsonProperty( PropertyName = "context", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public GitStatusContext Context { get; set; }

    //
    // Сводка:
    //     Creation date and time of the status.
    [JsonProperty( PropertyName = "creationDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime CreationDate { get; set; }

    //
    // Сводка:
    //     Last update date and time of the status.
    [JsonProperty( PropertyName = "updatedDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime UpdatedDate { get; set; }

    //
    // Сводка:
    //     Identity that created the status.
    [JsonProperty( PropertyName = "createdBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public IdentityRef CreatedBy { get; set; }

    //
    // Сводка:
    //     URL with status details.
    [JsonProperty( PropertyName = "targetUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string TargetUrl { get; set; }

    //
    // Сводка:
    //     Reference links.
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "_links")]
    public ReferenceLinks Links { get; set; }
}
