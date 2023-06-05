namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneRuinsLootLaboratory : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Ruins - Loot - Laboratory";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // loot
            scripts
                .Add(GetScript<SpawnLootRuinsLaboratory>())
                .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))

                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}