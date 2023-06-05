namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneBorealMountain : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Boreal - Mountain";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals
            scripts
                .Add(GetScript<SpawnResourceCopper>())
                .Add(GetScript<SpawnResourceIron>())
                .Add(GetScript<SpawnResourceStone>().Configure(densityMultiplier: 0.5))
                .Add(GetScript<SpawnResourceCoal>())
                .Add(GetScript<SpawnResourceSaltpeter>())
                .Add(GetScript<SpawnResourceSulfur>());

            // loot
            scripts
                .Add(GetScript<SpawnLootPileMinerals>());

            // mobs
            scripts
                .Add(GetScript<SpawnMobsCloakedLizard>())
                .Add(GetScript<SpawnMobsCrawler>())
                 .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))
                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}