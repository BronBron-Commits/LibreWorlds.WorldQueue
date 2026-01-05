using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Interfaces
{
    public interface IWorldCommandQueue
    {
        void Enqueue(IWorldCommand command);

        IReadOnlyList<IWorldCommand> Drain();
    }
}
