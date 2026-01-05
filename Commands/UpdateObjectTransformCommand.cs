using System.Numerics;

namespace LibreWorlds.WorldQueue.Commands
{
    public sealed class UpdateObjectTransformCommand : WorldCommandBase
    {
        public int ObjectId { get; }
        public Vector3 Position { get; }
        public Quaternion Rotation { get; }

        public UpdateObjectTransformCommand(
            long sequence,
            int objectId,
            Vector3 position,
            Quaternion rotation)
            : base(sequence)
        {
            ObjectId = objectId;
            Position = position;
            Rotation = rotation;
        }
    }
}
