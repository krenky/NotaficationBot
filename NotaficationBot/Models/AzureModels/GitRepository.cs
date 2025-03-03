using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NotificationsBot.Models.AzureModels;

public class GitRepository
{
    public const string c_rootPath = "/";

    [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public Guid Id { get; set; }

    [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Url { get; set; }

    [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public TeamProjectReference ProjectReference { get; set; }

    [JsonProperty("defaultBranch", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string DefaultBranch { get; set; }

    //
    // Сводка:
    //     Compressed size (bytes) of the repository.
    [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public long? Size { get; set; }

    [JsonProperty("remoteUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string RemoteUrl { get; set; }

    [JsonProperty("sshUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string SshUrl { get; set; }

    [JsonProperty("webUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string WebUrl { get; set; }

    [JsonProperty("validRemoteUrls", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string[] ValidRemoteUrls { get; set; }

    //
    // Сводка:
    //     True if the repository was created as a fork.
    [JsonProperty("isFork", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool IsFork { get; set; }

    [JsonProperty("parentRepository", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public GitRepositoryRef ParentRepository { get; set; }

    //todo придумать что сделать с _links
    //[JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
    //public ReferenceLinks Links { get; set; }

    //
    // Сводка:
    //     True if the repository is disabled. False otherwise.
    [JsonProperty("isDisabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? IsDisabled { get; set; }

    //
    // Сводка:
    //     True if the repository is in maintenance. False otherwise.
    [JsonProperty("isInMaintenance", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? IsInMaintenance { get; set; }

    public string GetTeamProjectUri()
    {
        string result = null;
        if (ProjectReference != null)
        {
            result = LinkingUtilities.EncodeUri(new ArtifactId("Classification", "TeamProject", ProjectReference.Id.ToString("D")));
        }

        return result;
    }
}

public class TeamProjectReference
{
    //
    // Сводка:
    //     Project identifier.
    [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public Guid Id { get; set; }

    //
    // Сводка:
    //     Project abbreviation.
    [JsonProperty(PropertyName = "abbreviation", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Abbreviation { get; set; }

    //
    // Сводка:
    //     Project name.
    [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Name { get; set; }

    //
    // Сводка:
    //     The project's description (if any).
    [JsonProperty(PropertyName = "Description", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Description { get; set; }

    //
    // Сводка:
    //     Url to the full version of the object.
    [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Url { get; set; }

    //
    // Сводка:
    //     Project state.
    [JsonProperty(PropertyName = "State")]
    public ProjectState State { get; set; }

    //
    // Сводка:
    //     Project revision.
    [DataMember(Order = 6, EmitDefaultValue = false)]
    public long Revision { get; set; }

    //
    // Сводка:
    //     Project visibility.
    [JsonProperty(PropertyName = "State")]
    public ProjectVisibility Visibility { get; set; }

    //
    // Сводка:
    //     Url to default team identity image.
    [DataMember(Order = 8, EmitDefaultValue = false)]
    public string DefaultTeamImageUrl { get; set; }

    //
    // Сводка:
    //     Project last update time.
    [JsonProperty(PropertyName = "lastUpdateTime")]
    public DateTime LastUpdateTime { get; set; }
}