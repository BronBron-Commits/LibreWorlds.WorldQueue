using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands;

/// <summary>
/// Base class for all queued world commands.
/// </summary>
public abstract class WorldCommandBase : IWorldCommand
{
    protected WorldCommandBase(long sequence)
    {
        Sequence = sequence;
    }

    public long Sequence { get; }
}
