using Newtonsoft.Json;

namespace NotificationsBot.Models.AzureModels;

public class Comment
{
    //
    // Сводка:
    //     The comment ID. IDs start at 1 and are unique to a pull request.
    [JsonProperty(PropertyName = "id")]
    public short Id { get; set; }

    //
    // Сводка:
    //     The ID of the parent comment. This is used for replies.
    [JsonProperty(PropertyName = "parentCommentId")]
    public short ParentCommentId { get; set; }

    //
    // Сводка:
    //     The parent thread ID. Used for internal server purposes only -- note that this
    //     field is not exposed to the REST client.
    internal int ThreadId { get; set; }

    //
    // Сводка:
    //     The author of the comment.
    [JsonProperty(PropertyName = "author")]
    public IdentityRef Author { get; set; }

    //
    // Сводка:
    //     The comment content.
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

    //
    // Сводка:
    //     The date the comment was first published.
    [JsonProperty(PropertyName = "publishedDate")]
    public DateTime PublishedDate { get; set; }

    //
    // Сводка:
    //     The date the comment was last updated.
    [JsonProperty(PropertyName = "lastUpdatedDate")]
    public DateTime LastUpdatedDate { get; set; }

    //
    // Сводка:
    //     The date the comment's content was last updated.
    [JsonProperty(PropertyName = "lastContentUpdatedDate")]
    public DateTime LastContentUpdatedDate { get; set; }

    //
    // Сводка:
    //     Whether or not this comment was soft-deleted.
    [JsonProperty(PropertyName = "isDeleted")]
    public bool IsDeleted { get; set; }

    //
    // Сводка:
    //     The comment type at the time of creation.
    [JsonProperty(PropertyName = "commentType")]
    public CommentType CommentType { get; set; }

    //
    // Сводка:
    //     A list of the users who have liked this comment.
    [JsonProperty(PropertyName = "usersLiked")]
    public IList<IdentityRef> UsersLiked { get; set; }

    //
    // Сводка:
    //     Links to other related objects.
    [JsonProperty(PropertyName = "_links")]
    public ReferenceLinks Links { get; set; }
}
