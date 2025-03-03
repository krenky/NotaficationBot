using Microsoft.VisualStudio.Services.WebApi;
using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class IdentityRef
{
    //[JsonProperty(PropertyName = "descriptor", DefaultValueHandling = DefaultValueHandling.Ignore)]
    //public SubjectDescriptor Descriptor { get; set; }

    [JsonProperty(PropertyName = "displayName", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string DisplayName { get; set; }
    [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Url { get; set; }

    [JsonProperty(PropertyName = "_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public ReferenceLinks Links { get; set; }

    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    [JsonProperty(PropertyName = "uniqueName", DefaultValueHandling = DefaultValueHandling.Ignore)]
    [JsonConverter(typeof(DefaultValueOnPublicAccessJsonConverter<string>))]
    public string UniqueName { get; set; }

    [JsonProperty(PropertyName = "directoryAlias", DefaultValueHandling = DefaultValueHandling.Ignore)]
    [JsonConverter(typeof(DefaultValueOnPublicAccessJsonConverter<string>))]
    public string DirectoryAlias { get; set; }

    [JsonProperty(PropertyName = "profileUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
    [JsonConverter(typeof(DefaultValueOnPublicAccessJsonConverter<string>))]
    public string ProfileUrl { get; set; }

    [JsonProperty(PropertyName = "imageUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
    [JsonConverter(typeof(DefaultValueOnPublicAccessJsonConverter<string>))]
    public string ImageUrl { get; set; }

    [JsonProperty(PropertyName = "isContainer", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool IsContainer { get; set; }

    [JsonProperty(PropertyName = "isAadIdentity", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool IsAadIdentity { get; set; }

    [JsonProperty(PropertyName = "inactive", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool Inactive { get; set; }

    [JsonProperty(PropertyName = "isDeletedInOrigin", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
    public bool IsDeletedInOrigin { get; set; }
}
