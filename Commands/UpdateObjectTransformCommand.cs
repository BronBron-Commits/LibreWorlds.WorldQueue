using System.Numerics;

namespace LibreWorlds.WorldQueue.Commands;

public sealed class UpdateObjectTransformCommand
{
    public long ObjectId { get; }
    public Vector3 Position { get; }
    public Quaternion Rotation { get; }

    public UpdateObjectTransformCommand(long objectId, Vector3 position, Quaternion rotation)
    {
        ObjectId = objectId;
        Position = position;
        Rotation = rotation;
    }
}
