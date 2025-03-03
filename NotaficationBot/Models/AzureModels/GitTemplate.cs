using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class GitTemplate
{
    //
    // Сводка:
    //     Name of the Template
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    //
    // Сводка:
    //     Type of the Template
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }
}
