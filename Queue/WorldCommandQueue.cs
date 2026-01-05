using System.Collections.Concurrent;
using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Queue
{
    public sealed class WorldCommandQueue : IWorldCommandQueue
    {
        private readonly ConcurrentQueue<IWorldCommand> _queue = new();

        public void Enqueue(IWorldCommand command)
        {
            _queue.Enqueue(command);
        }

        public bool TryDequeue(out IWorldCommand command)
        {
            return _queue.TryDequeue(out command);
        }
    }
}
