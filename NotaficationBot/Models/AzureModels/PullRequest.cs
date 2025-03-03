using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace NotificationsBot.Models.AzureModels;

[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class PullRequest
{
    [JsonProperty(PropertyName = "repository")]
    public GitRepository Repository { get; set; }

    [JsonProperty(PropertyName = "pullRequestId")]
    public int PullRequestId { get; set; }

    [JsonProperty(PropertyName = "codeReviewId")]
    public int CodeReviewId { get; set; }

    [JsonProperty(PropertyName = "status")]
    public PullRequestStatus Status { get; set; }

    [JsonProperty(PropertyName = "createdBy")]
    public IdentityRef CreatedBy { get; set; }

    [JsonProperty(PropertyName = "creationDate")]
    public DateTime CreationDate { get; set; }

    [JsonProperty(PropertyName = "closedDate")]
    public DateTime ClosedDate { get; set; }

    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    [JsonProperty(PropertyName = "sourceRefName")]
    public string SourceRefName { get; set; }

    [JsonProperty(PropertyName = "targetRefName")]
    public string TargetRefName { get; set; }

    [JsonProperty(PropertyName = "mergeStatus")]
    public PullRequestAsyncStatus MergeStatus { get; set; }

    [JsonProperty(PropertyName = "mergeFailureType")]
    public PullRequestMergeFailureType MergeFailureType { get; set; }

    [JsonProperty(PropertyName = "mergeFailureMessage")]
    public string MergeFailureMessage { get; set; }

    [JsonProperty(PropertyName = "isDraft")]
    public bool? IsDraft { get; set; }

    [JsonProperty(PropertyName = "hasMultipleMergeBases")]
    public bool HasMultipleMergeBases { get; set; }

    [JsonProperty(PropertyName = "mergeId")]
    public Guid MergeId { get; set; }

    [JsonProperty(PropertyName = "lastMergeSourceCommit")]
    public GitCommitRef LastMergeSourceCommit { get; set; }

    [JsonProperty(PropertyName = "lastMergeTargetCommit")]
    public GitCommitRef LastMergeTargetCommit { get; set; }

    [JsonProperty(PropertyName = "lastMergeCommit")]
    public GitCommitRef LastMergeCommit { get; set; }

    [JsonProperty(PropertyName = "reviewers")]
    public IdentityRefWithVote[] Reviewers { get; set; }

    [JsonProperty(PropertyName = "labels")]
    public WebApiTagDefinition[] Labels { get; set; }

    [JsonProperty(PropertyName = "commits")]
    public GitCommitRef[] Commits { get; set; }

    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string RemoteUrl { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "_links")]
    public ReferenceLinks Links { get; set; }

    [JsonProperty(PropertyName = "completionOptions")]
    public GitPullRequestCompletionOptions CompletionOptions { get; set; }

    [JsonProperty(PropertyName = "mergeOptions")]
    public GitPullRequestMergeOptions MergeOptions { get; set; }

    [JsonProperty(PropertyName = "supportsIterations")]
    public bool SupportsIterations { get; set; }

    [JsonProperty(PropertyName = "workItemRefs")]
    public ResourceRef[] WorkItemRefs { get; set; }

    [JsonProperty(PropertyName = "completionQueueTime")]
    public DateTime CompletionQueueTime { get; set; }

    [JsonProperty(PropertyName = "closedBy")]
    public IdentityRef ClosedBy { get; set; }

    [JsonProperty(PropertyName = "autoCompleteSetBy")]
    public IdentityRef AutoCompleteSetBy { get; set; }

    [JsonProperty(PropertyName = "artifactId")]
    public string ArtifactId { get; set; }

    [JsonProperty(PropertyName = "forkSource")]
    public GitForkRef ForkSource { get; set; }
}
