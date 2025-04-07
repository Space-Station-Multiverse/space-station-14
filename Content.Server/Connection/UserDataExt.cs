using Content.Shared.Database;
using Robust.Shared.Network;

namespace Content.Server.Connection;

/// <summary>
/// Helper functions for working with <see cref="NetUserData"/>.
/// </summary>
public static class UserDataExt
{
    /// <summary>
    /// Get the preferred HWID that should be used for new records related to a player.
    /// </summary>
    /// <remarks>
    /// Players can have zero or more HWIDs, but for logging things like connection logs we generally
    /// only want a single one. This method returns a nullable method.
    /// </remarks>
    public static ImmutableTypedHwid? GetBestHwid(this NetUserData userData)
    {
        if (userData.ModernHWIds.Length > 0)
        {
            // Prefer modern style
            return new ImmutableTypedHwid(userData.ModernHWIds[0], HwidType.Modern);
        } else if (userData.HWId.Length > 0) {
            // Fall back to legacy hwid, if available
            return new ImmutableTypedHwid(userData.HWId, HwidType.Legacy);
        } else {
            return null; // Nothing
        }
    }
}
