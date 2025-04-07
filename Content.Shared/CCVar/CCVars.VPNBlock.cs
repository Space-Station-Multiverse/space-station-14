using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

/// <summary>
/// CCVars for SSMV's VPN Block implementation.  This predates wizden's by a bit, and now might be a bit duplicative
/// versus what upstream provides.  (They both use the same backing service)
/// </summary>

public sealed partial class CCVars
{
    /// <summary>
    /// Is VPN Block enabled?
    /// NOTE - Turning on MV VPN block turns off wizden VPN block.  (There is no reason to have both systems on at
    /// the same time, they both use the same backing API.)
    /// </summary>
    /// <param name="CVar.SERVER"></param>
    /// <returns></returns>
    public static readonly CVarDef<bool> VPNBlockEnabled =
        CVarDef.Create("vpn_block.enabled", false, CVar.NOTIFY | CVar.REPLICATED | CVar.SERVER);

    /// <summary>
    /// Minimal overall played time to skip VPN Block.
    /// </summary>
    public static readonly CVarDef<float> VPNBlockSkipWithMinOverallHours =
        CVarDef.Create("vpn_block.skip_with_min_overall_hours", 1.0f, CVar.SERVERONLY);

    /// <summary>
    /// Admin e-mail, is passed to IP service (is their requirement)
    /// https://getipintel.net/free-proxy-vpn-tor-detection-api/
    /// </summary>
    public static readonly CVarDef<string> VPNBlockAdminEmail =
        CVarDef.Create("vpn_block.admin_email", string.Empty, CVar.SERVERONLY | CVar.CONFIDENTIAL);

    /// <summary>
    /// At this value or above, server will consider IP to be suspicious and block it.  API recommends .99 or .995
    /// </summary>
    /// <returns></returns>
    public static readonly CVarDef<double> VPNBlockThresholdToBlockIP =
        CVarDef.Create("vpn_block.threshold_for_blocked_ip", 0.99, CVar.SERVERONLY);

    /// <summary>
    /// Admin e-mail, is passed to IP service (is their requirement)
    /// https://getipintel.net/free-proxy-vpn-tor-detection-api/
    /// </summary>
    public static readonly CVarDef<string> VPNBlockDenyMessage =
        CVarDef.Create("vpn_block.deny_message",
            "VPN BLOCKED\n" +
            "Hello, it appears you are connecting from a VPN and this server currently blocks VPN connections.  Please use a\n" +
            "residential/home IP.\n" +
            "\n" +
            "Alternatively, you may request a whitelist from server staff via discord, website, etc if you have a good record\n" +
            "on another server.  Please include your requested username and the public key from the launcher (launcher's \n" +
            "account drop down menu -> configure button -> copy/paste public key.)",
            CVar.SERVERONLY);
}
