using System;
using System.Numerics;

namespace LibreWorlds.WorldQueue.Commands
{
    public sealed class AddObjectCommand : WorldCommandBase
    {
        public int ObjectId { get; }
        public string ModelName { get; }
        public ReadOnlyMemory<byte> ModelBytes { get; }
        public Vector3 Position { get; }
        public Quaternion Rotation { get; }

        public AddObjectCommand(
            long sequence,
            int objectId,
            string modelName,
            ReadOnlyMemory<byte> modelBytes,
            Vector3 position,
            Quaternion rotation)
            : base(sequence)
        {
            ObjectId = objectId;
            ModelName = modelName;
            ModelBytes = modelBytes;
            Position = position;
            Rotation = rotation;
        }
    }
}
