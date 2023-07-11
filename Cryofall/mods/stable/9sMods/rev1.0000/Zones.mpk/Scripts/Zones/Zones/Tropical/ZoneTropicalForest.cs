namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneTropicalForest : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Tropical - Forest";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals
            scripts
                .Add(GetScript<SpawnResourcesGeneric>().Configure(densityMultiplier: 0.30))
                .Add(GetScript<SpawnResourceStone>().Configure(densityMultiplier: 0.20));

            // other vegetation
            scripts
                .Add(GetScript<SpawnBushesForestTropical>().Configure(densityMultiplier: 0.5))
                .Add(GetScript<SpawnMushroomsTemperate>().Configure(densityMultiplier: 0.25))
                .Add(GetScript<SpawnResourceHerbs>().Configure(densityMultiplier: 0.25));

            // trees
            scripts
                .Add(GetScript<SpawnTreesTropical>());

            // loot
            scripts
                .Add(GetScript<SpawnLootGeneric>()) // loot (stone, grass, twigs)
                .Add(GetScript<SpawnLootPileWood>())
                .Add(GetScript<SpawnLootPileStone>().Configure(densityMultiplier: 0.2));

            // mobs
            scripts
                // passive
                .Add(GetScript<SpawnMobsChicken>())
                .Add(GetScript<SpawnMobsPangolin>())
                // aggressive
                .Add(GetScript<SpawnMobsTropicalBoar>().Configure(densityMultiplier: 0.8))
                .Add(GetScript<SpawnMobsSnakeGreen>().Configure(densityMultiplier: 0.5))
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