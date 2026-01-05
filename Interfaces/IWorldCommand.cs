namespace LibreWorlds.WorldQueue.Interfaces;

/// <summary>
/// Represents a queued world command.
/// This is PURE DATA. No execution.
/// </summary>
public interface IWorldCommand
{
    /// <summary>
    /// Identifier for ordering / debugging.
    /// </summary>
    long Sequence { get; }
}
