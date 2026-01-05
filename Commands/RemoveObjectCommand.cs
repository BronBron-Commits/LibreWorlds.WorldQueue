using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands;

public sealed class RemoveObjectCommand : WorldCommandBase
{
    public int ObjectId { get; }

    public RemoveObjectCommand(long tick, int objectId)
        : base(tick)
    {
        ObjectId = objectId;
    }

    public override void Execute(IWorldEngine engine)
    {
        engine.RemoveObject(ObjectId);
    }
}
