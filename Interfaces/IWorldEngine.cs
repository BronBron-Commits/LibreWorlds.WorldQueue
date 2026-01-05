using System.Numerics;

namespace LibreWorlds.WorldQueue.Interfaces;

/// <summary>
/// Minimal authoritative world mutation surface.
/// Implemented by the runtime / engine layer.
/// </summary>
public interface IWorldEngine
{
    void AddObject(
        int objectId,
        string modelName,
        ReadOnlyMemory<byte> modelBytes,
        Vector3 position,
        Quaternion rotation);

    void UpdateObjectTransform(
        int objectId,
        Vector3 position,
        Quaternion rotation);

    void RemoveObject(int objectId);
}
