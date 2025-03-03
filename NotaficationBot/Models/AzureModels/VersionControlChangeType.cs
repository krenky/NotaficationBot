namespace NotificationsBot.Models.AzureModels;

[Flags]
public enum VersionControlChangeType
{
    None = 0,
    Add = 1,
    Edit = 2,
    Encoding = 4,
    Rename = 8,
    Delete = 0x10,
    Undelete = 0x20,
    Branch = 0x40,
    Merge = 0x80,
    Lock = 0x100,
    Rollback = 0x200,
    SourceRename = 0x400,
    TargetRename = 0x800,
    Property = 0x1000,
    All = 0x1FFF
}
