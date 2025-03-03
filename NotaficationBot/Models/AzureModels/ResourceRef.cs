using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class ResourceRef
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }
}
