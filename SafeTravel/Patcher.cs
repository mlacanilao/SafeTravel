using HarmonyLib;

namespace SafeTravel
{
    internal class Patcher
    {
        [HarmonyPrefix]
        [HarmonyPatch(declaringType: typeof(Chara), methodName: nameof(Chara.Tick))]
        internal static void CharaTick(Chara __instance)
        {
            CharaPatch.TickPrefix(__instance: __instance);
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(declaringType: typeof(Player), methodName: nameof(Player.EnterLocalZone), argumentTypes: new[] { typeof(bool), typeof(Chara) })]
        internal static bool PlayerEnterLocalZone(bool encounter)
        {
            return PlayerPatch.EnterLocalZonePrefix(encounter: encounter);
        }
    }
}