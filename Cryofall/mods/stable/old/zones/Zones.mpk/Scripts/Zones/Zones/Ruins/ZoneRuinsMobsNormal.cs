namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneRuinsMobsNormal : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Ruins - Mobs - Normal";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            scripts
                .Add(GetScript<SpawnMobsRuinsNormal>())
                .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))

                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}