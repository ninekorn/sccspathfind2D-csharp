namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneArcticForest : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Arctic - Forest";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // no pvp resources spawn, this area is a quiet "haven"

            // minerals
            scripts
                .Add(GetScript<SpawnResourceStone>().Configure(densityMultiplier: 0.15));

            // trees
            scripts
                .Add(GetScript<SpawnTreesArctic>());

            // loot
            scripts
                .Add(GetScript<SpawnLootPileWood>())
                .Add(GetScript<SpawnLootPileStone>().Configure(densityMultiplier: 0.2));

            // mobs
            scripts
                .Add(GetScript<SpawnMobsWolfPolar>())
                .Add(GetScript<SpawnMobsBearPolar>())
                .Add(GetScript<SpawnMobsBroodNest>())
                .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant0>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant1>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant2>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant3>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant4>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant5>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant6>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant7>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant8>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant0>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant1>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant2>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant3>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant4>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant5>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant6>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant7>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant8>().Configure(densityMultiplier: 0.2));



        }
    }
}