using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

/// <summary>
/// Auth (content-directed portion)
/// </summary>
public sealed partial class CCVars
{
    /// <summary>
    /// Intended for servers migrating from wizden accounts to multiverse keys.  It will migrate
    /// based on user's HWID if the following conditions are met:
    /// 1) Connecting user's public key does not already exist in DB
    /// 2) HWID between old & new user matches
    /// 3) User has no special permissions (do these by hand for safety)
    /// 4) Old user has no prior public key
    /// </summary>
    public static readonly CVarDef<bool> AuthMigrationViaHwid =
        CVarDef.Create("auth.migration_via_hwid", true, CVar.SERVERONLY);

    /// <summary>
    /// If an IP connecting requests to make a new public-key based account (or migrate an old one), then check
    /// the database to see if they're flooding.  Flooding will be an IP using X accounts in Y days.
    /// Setting either of these to 0 will disable the check.
    /// </summary>
    public static readonly CVarDef<float> AuthLimitNewPublicKeysFromIPForDays =
        CVarDef.Create("auth.limit_new_public_keys_from_ip_for_days", 14f, CVar.SERVERONLY);

    /// <summary>
    /// See above -- ip count part of the check.
    /// </summary>
    /// <returns></returns>
    public static readonly CVarDef<int> AuthLimitNewPublicKeysFromIPCount =
        CVarDef.Create("auth.limit_new_public_keys_from_ip_count", 5, CVar.SERVERONLY);

}
