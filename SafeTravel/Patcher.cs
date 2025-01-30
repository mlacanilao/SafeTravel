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
    }
}