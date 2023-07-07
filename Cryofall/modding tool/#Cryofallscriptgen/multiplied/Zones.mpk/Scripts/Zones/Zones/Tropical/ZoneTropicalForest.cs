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
            //scripts
            // passive
            //    .Add(GetScript<SpawnMobsChicken>())
            //    .Add(GetScript<SpawnMobsPangolin>())
            // aggressive
            //    .Add(GetScript<SpawnMobsTropicalBoar>().Configure(densityMultiplier: 0.8))
            //    .Add(GetScript<SpawnMobsSnakeGreen>().Configure(densityMultiplier: 0.5));

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

			//TropicalBoar
			scripts.Add(GetScript<SpawnMobsTropicalBoar>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTropicalBoarVariant8>().Configure(densityMultiplier: 0.09));

			//SnakeGreen
			scripts.Add(GetScript<SpawnMobsSnakeGreen>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeGreenVariant8>().Configure(densityMultiplier: 0.09));

			//Pangolin
			scripts.Add(GetScript<SpawnMobsPangolin>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant8>().Configure(densityMultiplier: 0.09));

			//Chicken
			scripts.Add(GetScript<SpawnMobsChicken>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsChickenVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}