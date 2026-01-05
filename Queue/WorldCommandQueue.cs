using System.Collections.Concurrent;
using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Queue
{
    public sealed class WorldCommandQueue : IWorldCommandQueue
    {
        private readonly ConcurrentQueue<IWorldCommand> _queue = new();

        public void Enqueue(IWorldCommand command)
        {
            if (command is null)
                throw new ArgumentNullException(nameof(command));

            _queue.Enqueue(command);
        }

        public IReadOnlyList<IWorldCommand> Drain()
        {
            var list = new List<IWorldCommand>();

            while (_queue.TryDequeue(out var cmd))
            {
                list.Add(cmd);
            }

            return list;
        }
    }
}
