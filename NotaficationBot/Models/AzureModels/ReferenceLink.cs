using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class ReferenceLink
{
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }
}
