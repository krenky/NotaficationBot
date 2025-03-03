using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class IdentityRefWithVote : IdentityRef
{

    /// <summary>URL to retrieve information about this identity</summary>
    [JsonProperty(PropertyName = "reviewerUrl")]
    public string ReviewerUrl { get; set; }

    /// <summary>
    /// Vote on a pull request:<br />
    /// 10 - approved
    /// 5 - approved with suggestions
    /// 0 - no vote
    /// -5 - waiting for author
    /// -10 - rejected
    /// </summary>
    [JsonProperty(PropertyName = "vote")]
    public short Vote { get; set; }

    /// <summary>
    /// Groups or teams that this reviewer contributed to.
    /// <br />
    /// Groups and teams can be reviewers on pull requests but can not vote directly.  When a member of
    /// the group or team votes, that vote is rolled up into the group or team vote.  VotedFor is a list
    /// of such votes.
    /// </summary>
    [JsonProperty(PropertyName = "votedFor", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public IdentityRefWithVote[] VotedFor { get; set; }

    /// <summary>
    /// Indicates if this reviewer has declined to review this pull request.
    /// </summary>
    [JsonProperty(PropertyName = "hasDeclined", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? HasDeclined { get; set; }

    /// <summary>
    /// Indicates if this is a required reviewer for this pull request.
    /// <br />
    /// Branches can have policies that require particular reviewers are required for pull requests.
    /// </summary>
    [JsonProperty(PropertyName = "isRequired", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool IsRequired { get; set; }

    /// <summary>
    /// Indicates if this reviewer is flagged for attention on this pull request.
    /// </summary>
    [JsonProperty(PropertyName = "isFlagged", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? IsFlagged { get; set; }

    /// <summary>
    /// Indicates if this approve vote should still be handled even though vote didn't change.
    /// </summary>
    [JsonProperty(PropertyName = "isReapprove", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? IsReapprove { get; set; }
}
