namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneBorealCoastOcean : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Boreal - Coast - Ocean";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals
            scripts
                .Add(GetScript<SpawnResourceSand>());

            // loot
            scripts
                .Add(GetScript<SpawnLootStone>());

            // mobs
            scripts
                .Add(GetScript<SpawnMobsCrab>())
                .Add(GetScript<SpawnMobsRiverSnail>())
                .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.95))
                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.95));
        }
    }
}