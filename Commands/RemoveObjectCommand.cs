namespace LibreWorlds.WorldQueue.Commands;

public sealed class RemoveObjectCommand : WorldCommandBase
{
    public RemoveObjectCommand(long sequence, long objectId)
        : base(sequence)
    {
        ObjectId = objectId;
    }

    public long ObjectId { get; }
}
