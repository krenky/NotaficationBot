using Microsoft.TeamFoundation.SourceControl.WebApi;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NotificationsBot.Models.AzureModels;

public class Change<T>
{
    //
    // Сводка:
    //     Current version.
    [JsonProperty(PropertyName = "item", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public T Item { get; set; }

    //
    // Сводка:
    //     Path of the item on the server.
    [JsonProperty(PropertyName = "sourceServerItem", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string SourceServerItem { get; set; }

    //
    // Сводка:
    //     The type of change that was made to the item.
    [JsonProperty(PropertyName = "changeType", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public VersionControlChangeType ChangeType { get; set; }

    //
    // Сводка:
    //     Content of the item after the change.
    [JsonProperty(PropertyName = "newContent", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public ItemContent NewContent { get; set; }

    //
    // Сводка:
    //     URL to retrieve the item.
    [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Url { get; set; }
}
