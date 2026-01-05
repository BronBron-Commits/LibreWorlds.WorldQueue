namespace LibreWorlds.WorldQueue.Interfaces
{
    public interface IWorldCommand
    {
        long Sequence { get; }

        void ExecuteOn(IWorldEngine engine);
    }
}
