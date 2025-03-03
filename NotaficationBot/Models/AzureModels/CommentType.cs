namespace NotificationsBot.Models.AzureModels;

public enum CommentType
{
    //
    // Сводка:
    //     The comment type is not known.
    Unknown,
    //
    // Сводка:
    //     This is a regular user comment.
    Text,
    //
    // Сводка:
    //     The comment comes as a result of a code change.
    CodeChange,
    //
    // Сводка:
    //     The comment represents a system message.
    System
}
