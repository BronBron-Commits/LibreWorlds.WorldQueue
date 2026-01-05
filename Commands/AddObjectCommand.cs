using System.Numerics;

namespace LibreWorlds.WorldQueue.Commands
{
    public sealed record AddObjectCommand(
        long Sequence,
        int ObjectId,
        string ModelName,
        ReadOnlyMemory<byte> ModelBytes,
        Vector3 Position,
        Quaternion Rotation
    ) : WorldCommandBase(Sequence);
}
