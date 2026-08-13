using BepInEx;
using UnityEngine;

namespace NoCooldown;

[BepInPlugin("bluududslostacc.sudo.nocooldown", "No Cooldown", "1.0.0")]
public sealed class NoCooldown : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("No Cooldown loaded.");
    }

    private void Update()
    {
        // Toggle placeholder: the gameplay-specific cooldown hooks depend on the
        // current ULTRAKILL build. This plugin is intentionally kept safe and local.
        if (Input.GetKeyDown(KeyCode.F8))
            Logger.LogInfo("No Cooldown toggle pressed.");
    }
}
