namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneRuinsLootMilitary : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Ruins - Loot - Military";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // loot
            scripts
                .Add(GetScript<SpawnLootRuinsMilitary>())
                .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))

                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}