namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneGenericPragmiumWasteland : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Generic - Pragmium wasteland";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals and mobs
            scripts
                .Add(GetScript<SpawnPragmiumWasteland>());

            scripts
             .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))

                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}