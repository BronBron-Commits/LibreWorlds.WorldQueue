namespace LibreWorlds.WorldQueue.Interfaces
{
    /// <summary>
    /// Marker interface for ordered world commands.
    /// Commands contain data only.
    /// </summary>
    public interface IWorldCommand
    {
        long Sequence { get; }
    }
}
