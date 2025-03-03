using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class GitPushRef
{
    [JsonProperty(PropertyName = "pushedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public IdentityRef PushedBy { get; set; }

    [JsonProperty(PropertyName = "pushId", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int PushId { get; set; }

    [Obsolete("This is unused as of Dev15 M115 and may be deleted in the future")]
    [JsonProperty(PropertyName = "pushCorrelationId", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public Guid PushCorrelationId { get; set; }

    [JsonProperty(PropertyName = "date", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime Date { get; set; }

    [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Url { get; set; }

    [JsonProperty(PropertyName = "_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public ReferenceLinks Links { get; set; }
}
