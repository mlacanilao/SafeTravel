namespace SafeTravel
{
    internal static class CharaPatch
    {
        internal static void TickPrefix(Chara __instance)
        {
            if (EClass.core?.IsGameStarted == false ||
                EClass._zone?.IsRegion == false ||
                __instance.IsPC == false)
            {
                return;
            }
            
            EClass.player.safeTravel = 1;
        }
    }
}