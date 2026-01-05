using LibreWorlds.WorldQueue.Interfaces;

namespace LibreWorlds.WorldQueue.Commands;

public abstract class WorldCommandBase : IWorldCommand
{
    protected WorldCommandBase(long tick)
    {
        Tick = tick;
    }

    public long Tick { get; }

    public abstract void Execute(IWorldEngine engine);
}
