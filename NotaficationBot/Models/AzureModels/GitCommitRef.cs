using Newtonsoft.Json;
using System.ComponentModel;

namespace NotificationsBot.Models.AzureModels;

public class GitCommitRef
{
    //
    // Сводка:
    //     ID (SHA-1) of the commit.
    [JsonProperty(PropertyName = "commitId")]
    public string CommitId { get; set; }

    //
    // Сводка:
    //     Author of the commit.
    [JsonProperty(PropertyName = "author")]
    public GitUserDate Author { get; set; }

    //
    // Сводка:
    //     Committer of the commit.
    [JsonProperty(PropertyName = "committer")]
    public GitUserDate Committer { get; set; }

    //
    // Сводка:
    //     Comment or message of the commit.
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    //
    // Сводка:
    //     Indicates if the comment is truncated from the full Git commit comment message.
    [JsonProperty(PropertyName = "commentTruncated")]
    public bool CommentTruncated { get; set; }

    //
    // Сводка:
    //     Counts of the types of changes (edits, deletes, etc.) included with the commit.
    [JsonProperty(PropertyName = "changeCounts")]
    public ChangeCountDictionary ChangeCounts { get; set; }

    //
    // Сводка:
    //     An enumeration of the changes included with the commit.
    [JsonProperty(PropertyName = "changes")]
    public IEnumerable<GitChange> Changes { get; set; }

    //
    // Сводка:
    //     An enumeration of the parent commit IDs for this commit.
    [JsonProperty(PropertyName = "parents")]
    public IEnumerable<string> Parents { get; set; }

    //
    // Сводка:
    //     REST URL for this resource.
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    //
    // Сводка:
    //     Remote URL path to the commit.
    [JsonProperty(PropertyName = "remoteUrl")]
    public string RemoteUrl { get; set; }

    //
    // Сводка:
    //     A collection of related REST reference links.
    [JsonProperty(PropertyName = "_links")]
    public ReferenceLinks Links { get; set; }

    //
    // Сводка:
    //     A list of status metadata from services and extensions that may associate additional
    //     information to the commit.
    [JsonProperty(PropertyName = "statuses")]
    public IList<GitStatus> Statuses { get; set; }

    //
    // Сводка:
    //     A list of workitems associated with this commit.
    [JsonProperty(PropertyName = "workItems")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IList<ResourceRef> WorkItems { get; set; }

    //
    // Сводка:
    //     The push associated with this commit.
    [JsonProperty(PropertyName = "push")]
    public GitPushRef Push { get; set; }

    //
    // Сводка:
    //     Indicates that commit contains too many changes to be displayed
    [JsonProperty(PropertyName = "commitTooManyChanges")]
    public bool CommitTooManyChanges { get; set; }
}
