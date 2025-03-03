using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class SubjectDescriptor
{
    [JsonProperty(PropertyName = "subjectType")]
    public string SubjectType { get; private set; }

    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; private set; }
}
