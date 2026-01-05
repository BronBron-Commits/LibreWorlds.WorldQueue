using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands
{
    public abstract class WorldCommandBase : IWorldCommand
    {
        public long Sequence { get; }

        protected WorldCommandBase(long sequence)
        {
            Sequence = sequence;
        }
    }
}
