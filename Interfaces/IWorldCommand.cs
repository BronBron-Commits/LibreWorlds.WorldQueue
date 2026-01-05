namespace LibreWorlds.WorldQueue.Interfaces;

public interface IWorldCommand
{
    void Execute(IWorldEngine engine);
}
