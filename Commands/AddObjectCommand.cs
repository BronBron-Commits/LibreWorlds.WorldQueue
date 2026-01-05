using System.Numerics;
using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands;

public sealed class AddObjectCommand : WorldCommandBase
{
    public int ObjectId { get; }
    public string ModelName { get; }
    public ReadOnlyMemory<byte> ModelBytes { get; }
    public Vector3 Position { get; }
    public Quaternion Rotation { get; }

    public AddObjectCommand(
        long tick,
        int objectId,
        string modelName,
        ReadOnlyMemory<byte> modelBytes,
        Vector3 position,
        Quaternion rotation)
        : base(tick)
    {
        ObjectId = objectId;
        ModelName = modelName;
        ModelBytes = modelBytes;
        Position = position;
        Rotation = rotation;
    }

    public override void Execute(IWorldEngine engine)
    {
        engine.AddObject(
            ObjectId,
            ModelName,
            ModelBytes,
            Position,
            Rotation);
    }
}
