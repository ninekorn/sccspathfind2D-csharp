namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneTemperateSalt : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Temperate - Salt pit";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals
            scripts
                .Add(GetScript<SpawnResourceSalt>());

            // mobs
            scripts
                .Add(GetScript<SpawnMobsCloakedLizard>())
                .Add(GetScript<SpawnMobsCrawler>())
                .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))

                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}