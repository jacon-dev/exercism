namespace infiltration
{
    public static class Infiltration
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            return !knightIsAwake;
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            return !new[] { knightIsAwake, archerIsAwake, prisonerIsAwake }.All(x => !x);
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            return (!archerIsAwake && prisonerIsAwake) ? true : false;
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (new[] { knightIsAwake, archerIsAwake, prisonerIsAwake }.All(x => x)) return false;
            if (new[] { knightIsAwake, archerIsAwake, prisonerIsAwake }.All(x => !x) && !petDogIsPresent) return false;
            if (archerIsAwake) return false;
            if (knightIsAwake) return false;
            return true;
        }
    }
}