namespace LibreWorlds.WorldQueue.Commands
{
    public sealed class RemoveObjectCommand : WorldCommandBase
    {
        public int ObjectId { get; }

        public RemoveObjectCommand(long sequence, int objectId)
            : base(sequence)
        {
            ObjectId = objectId;
        }
    }
}
