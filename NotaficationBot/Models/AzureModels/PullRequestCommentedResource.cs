using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;
//todo ненужная хуйня,Возможно, нужно проверить
public class PullRequestCommentedResource
{
    [JsonProperty(PropertyName = "pullRequest")]
    public required PullRequest PullRequest { get; set; }
    [JsonProperty(PropertyName = "comment")]
    public required Comment Comment { get; set; }
}
