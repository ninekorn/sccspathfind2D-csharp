namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.CoreMod.Systems.PvE;
    using AtomicTorch.CBND.GameApi;

    public class ZoneBorealForest : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Boreal - Forest";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            if (!PveSystem.ServerIsPvE)
            {
                // spawn resource deposits on PvP servers
                scripts
                    .Add(GetScript<SpawnDepositGeothermalSpring>().Configure(densityMultiplier: 0.5));
            }

            // minerals
            scripts
                .Add(GetScript<SpawnResourcesGeneric>().Configure(densityMultiplier: 0.35))
                .Add(GetScript<SpawnResourceStone>().Configure(densityMultiplier: 0.1));

            // trees
            scripts
                .Add(GetScript<SpawnTreesBoreal>())
                // tree stumps, fallen trees, basically decorations that behave like trees in terms of chopping wood
                .Add(GetScript<SpawnStumpsTemperate>().Configure(densityMultiplier: 0.75));

            // other vegetation
            scripts
                .Add(GetScript<SpawnBushesForestBoreal>().Configure(densityMultiplier: 0.5))
                .Add(GetScript<SpawnMushroomsBoreal>().Configure(densityMultiplier: 0.30))
                .Add(GetScript<SpawnResourceHerbs>().Configure(densityMultiplier: 0.30));

            // loot
            scripts
                .Add(GetScript<SpawnLootGeneric>()) // loot (stone, grass, twigs)
                .Add(GetScript<SpawnLootPileWood>())
                .Add(GetScript<SpawnLootPileStone>().Configure(densityMultiplier: 0.2));

            // mobs
            scripts
                // aggressive
                .Add(GetScript<SpawnMobsWolf>())
                .Add(GetScript<SpawnMobsWildBoar>())
                .Add(GetScript<SpawnMobsSnakeBlue>())
                .Add(GetScript<SpawnMobsBear>())
                // mutants
                .Add(GetScript<SpawnMobsMutantWolf>())
                .Add(GetScript<SpawnMobsMutantBoar>())
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