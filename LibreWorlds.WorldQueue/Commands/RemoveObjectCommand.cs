namespace LibreWorlds.WorldQueue.Commands
{
    public sealed record RemoveObjectCommand(
        long Sequence,
        int ObjectId
    ) : WorldCommandBase(Sequence);
}
