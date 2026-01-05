using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Interfaces
{
    public interface IWorldCommandQueue
    {
        void Enqueue(IWorldCommand command);

        bool TryDequeue(out IWorldCommand command);
    }
}
