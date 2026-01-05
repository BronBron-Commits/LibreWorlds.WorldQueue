using System.Numerics;
using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands;

public sealed class UpdateObjectTransformCommand : WorldCommandBase
{
    public int ObjectId { get; }
    public Vector3 Position { get; }
    public Quaternion Rotation { get; }

    public UpdateObjectTransformCommand(
        long tick,
        int objectId,
        Vector3 position,
        Quaternion rotation)
        : base(tick)
    {
        ObjectId = objectId;
        Position = position;
        Rotation = rotation;
    }

    public override void Execute(IWorldEngine engine)
    {
        engine.UpdateObjectTransform(
            ObjectId,
            Position,
            Rotation);
    }
}
