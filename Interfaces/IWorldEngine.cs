using System.Numerics;

namespace LibreWorlds.WorldQueue.Interfaces
{
    public interface IWorldEngine
    {
        void AddObject(
            int id,
            string modelName,
            ReadOnlyMemory<byte> modelData,
            Vector3 position,
            Quaternion rotation);

        void UpdateObjectTransform(
            int id,
            Vector3 position,
            Quaternion rotation);

        void RemoveObject(int id);
    }
}
