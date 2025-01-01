namespace infiltration
{
    public static class Infiltration
    {
        public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => !new[] { knightIsAwake, archerIsAwake, prisonerIsAwake }.All(x => !x);

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (new[] { knightIsAwake, archerIsAwake, prisonerIsAwake }.All(x => x)) return false;
            if (new[] { knightIsAwake, archerIsAwake, prisonerIsAwake }.All(x => !x)) return petDogIsPresent;
            if (archerIsAwake) return false;
            if (knightIsAwake) return petDogIsPresent;
            return prisonerIsAwake;
        }
    }
}