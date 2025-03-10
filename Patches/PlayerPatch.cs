namespace SafeTravel
{
    internal static class PlayerPatch
    {
        internal static bool EnterLocalZonePrefix(bool encounter)
        {
            if (encounter == true)
            {
                return false;
            }
            
            return true;
        }
    }
}