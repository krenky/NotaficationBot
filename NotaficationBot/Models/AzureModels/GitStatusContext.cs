using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class GitStatusContext
{
    //
    // Сводка:
    //     Name identifier of the status, cannot be null or empty.
    [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Name { get; set; }

    //
    // Сводка:
    //     Genre of the status. Typically name of the service/tool generating the status,
    //     can be empty.
    [JsonProperty(PropertyName = "genre", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Genre { get; set; }
}
