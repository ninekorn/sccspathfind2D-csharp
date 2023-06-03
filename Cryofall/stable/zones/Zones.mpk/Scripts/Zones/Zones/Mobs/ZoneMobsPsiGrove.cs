namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneMobsPsiGrove : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Mobs - Psi grove";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            scripts
                .Add(GetScript<SpawnMobsPsiGrove>())
                .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))

                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}