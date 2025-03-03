using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class GitItem
{
    //
    // Сводка:
    //     Git object id
    [JsonProperty(PropertyName = "objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string ObjectId { get; set; }

    //
    // Сводка:
    //     Git object id
    [JsonProperty(PropertyName = "originalObjectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string OriginalObjectId { get; set; }

    //
    // Сводка:
    //     Type of object (Commit, Tree, Blob, Tag, ...)
    [JsonProperty(PropertyName = "gitObjectType", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public GitObjectType GitObjectType { get; set; }

    //
    // Сводка:
    //     SHA1 of commit item was fetched at
    [JsonProperty(PropertyName = "commitId", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string CommitId { get; set; }

    //
    // Сводка:
    //     Shallow ref to commit that last changed this item Only populated if latestProcessedChange
    //     is requested May not be accurate if latest change is not yet cached
    [JsonProperty(PropertyName = "latestProcessedChange", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public GitCommitRef LatestProcessedChange { get; set; }
}
