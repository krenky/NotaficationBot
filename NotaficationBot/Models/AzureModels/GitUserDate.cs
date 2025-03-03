using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class GitUserDate
{
    //
    // Сводка:
    //     Name of the user performing the Git operation.
    [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Name { get; set; }

    //
    // Сводка:
    //     Email address of the user performing the Git operation.
    [JsonProperty(PropertyName = "email", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Email { get; set; }

    //
    // Сводка:
    //     Date of the Git operation.
    [JsonProperty(PropertyName = "date", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime Date { get; set; }

    //
    // Сводка:
    //     Url for the user's avatar.
    [JsonProperty(PropertyName = "imageUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string ImageUrl { get; set; }
}
