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
            //scripts
            // aggressive
            //  .Add(GetScript<SpawnMobsWolf>())
            //  .Add(GetScript<SpawnMobsWildBoar>())
            //  .Add(GetScript<SpawnMobsSnakeBlue>())
            //   .Add(GetScript<SpawnMobsBear>())
            // mutants
            //   .Add(GetScript<SpawnMobsMutantWolf>())
            //   .Add(GetScript<SpawnMobsMutantBoar>());

            //9SMODS\\
			//Zombie
			scripts.Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsZombieVariant8>().Configure(densityMultiplier: 0.09));

			//Skeleton
			scripts.Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSkeletonVariant8>().Configure(densityMultiplier: 0.09));

			//Wolf
			scripts.Add(GetScript<SpawnMobsWolf>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfVariant8>().Configure(densityMultiplier: 0.09));

			//WildBoar
			scripts.Add(GetScript<SpawnMobsWildBoar>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWildBoarVariant8>().Configure(densityMultiplier: 0.09));

			//SnakeBlue
			scripts.Add(GetScript<SpawnMobsSnakeBlue>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBlueVariant8>().Configure(densityMultiplier: 0.09));

			//MutantWolf
			scripts.Add(GetScript<SpawnMobsMutantWolf>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantWolfVariant8>().Configure(densityMultiplier: 0.09));

			//MutantBoar
			scripts.Add(GetScript<SpawnMobsMutantBoar>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantBoarVariant8>().Configure(densityMultiplier: 0.09));

			//Bear
			scripts.Add(GetScript<SpawnMobsBear>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}