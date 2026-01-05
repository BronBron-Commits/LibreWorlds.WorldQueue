namespace LibreWorlds.WorldQueue.Commands;

public sealed class RemoveObjectCommand
{
    public long ObjectId { get; }

    public RemoveObjectCommand(long objectId)
    {
        ObjectId = objectId;
    }
}
