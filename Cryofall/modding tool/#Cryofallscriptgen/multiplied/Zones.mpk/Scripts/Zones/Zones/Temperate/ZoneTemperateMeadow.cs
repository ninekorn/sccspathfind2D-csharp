namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneTemperateMeadow : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Temperate - Meadow";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // different vegetation
            scripts
                .Add(GetScript<SpawnBushesForestTemperate>())
                .Add(GetScript<SpawnMushroomsTemperate>())
                // default density for herbs compared to forest, we want them to spawn here a lot
                .Add(GetScript<SpawnResourceHerbs>());

            // loot
            scripts
                .Add(GetScript<SpawnLootGeneric>().Configure(densityMultiplier: 1.35)); // loot (stone, grass, twigs)

            // mobs
            //scripts
            //    .Add(GetScript<SpawnMobsWolf>())
            //    .Add(GetScript<SpawnMobsChicken>())
            //    .Add(GetScript<SpawnMobsWildBoar>())
            //    .Add(GetScript<SpawnMobsSnakeGreen>());

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