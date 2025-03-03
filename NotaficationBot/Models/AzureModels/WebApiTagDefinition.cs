using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class WebApiTagDefinition
{
    //
    // Сводка:
    //     ID of the tag definition.
    [JsonProperty( PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public Guid Id { get; set; }

    //
    // Сводка:
    //     The name of the tag definition.
    [JsonProperty( PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Name { get; set; }

    //
    // Сводка:
    //     Whether or not the tag definition is active.
    [JsonProperty( PropertyName = "active", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? Active { get; set; }

    //
    // Сводка:
    //     Resource URL for the Tag Definition.
    [JsonProperty( PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Url { get; set; }
}
