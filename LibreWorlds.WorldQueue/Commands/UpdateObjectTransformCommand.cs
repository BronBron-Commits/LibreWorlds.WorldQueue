using System.Numerics;

namespace LibreWorlds.WorldQueue.Commands
{
    public sealed record UpdateObjectTransformCommand(
        long Sequence,
        int ObjectId,
        Vector3 Position,
        Quaternion Rotation
    ) : WorldCommandBase(Sequence);
}
