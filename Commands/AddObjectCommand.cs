using System.Numerics;
using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands
{
    public sealed class AddObjectCommand : WorldCommandBase
    {
        private readonly int _id;
        private readonly string _model;
        private readonly ReadOnlyMemory<byte> _data;
        private readonly Vector3 _position;
        private readonly Quaternion _rotation;

        public AddObjectCommand(
            long sequence,
            int id,
            string model,
            ReadOnlyMemory<byte> data,
            Vector3 position,
            Quaternion rotation)
            : base(sequence)
        {
            _id = id;
            _model = model;
            _data = data;
            _position = position;
            _rotation = rotation;
        }

        public override void ExecuteOn(IWorldEngine engine)
        {
            engine.AddObject(_id, _model, _data, _position, _rotation);
        }
    }
}
