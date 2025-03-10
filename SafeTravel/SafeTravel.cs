using BepInEx;
using HarmonyLib;

namespace SafeTravel
{
    internal static class ModInfo
    {
        internal const string Guid = "omegaplatinum.elin.safetravel";
        internal const string Name = "Safe Travel";
        internal const string Version = "1.1.0.0";
    }

    [BepInPlugin(GUID: ModInfo.Guid, Name: ModInfo.Name, Version: ModInfo.Version)]
    internal class SafeTravel : BaseUnityPlugin
    {
        internal static SafeTravel Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
            
            Harmony.CreateAndPatchAll(type: typeof(Patcher), harmonyInstanceId: ModInfo.Guid);
        }

        internal static void Log(object payload)
        {
            Instance?.Logger.LogInfo(data: payload);
        }
    }
}
