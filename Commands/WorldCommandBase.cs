using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands
{
    public abstract record WorldCommandBase(long Sequence) : IWorldCommand;
}
