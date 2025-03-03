using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class ItemContent
{
    [JsonProperty(PropertyName = "content", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Content { get; set; }

    [JsonProperty(PropertyName = "contentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public ItemContentType ContentType { get; set; }
}
