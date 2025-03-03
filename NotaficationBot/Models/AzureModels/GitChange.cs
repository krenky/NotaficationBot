using Newtonsoft.Json;
using System.ComponentModel;

namespace NotificationsBot.Models.AzureModels;

public class GitChange : Change<GitItem>
{
    //
    // Сводка:
    //     Original path of item if different from current path.
    [JsonProperty(PropertyName = "originalPath", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string OriginalPath { get; set; }

    //
    // Сводка:
    //     ID of the change within the group of changes.
    [JsonProperty(PropertyName = "changeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int ChangeId { get; set; }

    //
    // Сводка:
    //     New Content template to be used when pushing new changes.
    [EditorBrowsable(EditorBrowsableState.Never)]
    [JsonProperty(PropertyName = "newContentTemplate", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public GitTemplate NewContentTemplate { get; set; }
}
