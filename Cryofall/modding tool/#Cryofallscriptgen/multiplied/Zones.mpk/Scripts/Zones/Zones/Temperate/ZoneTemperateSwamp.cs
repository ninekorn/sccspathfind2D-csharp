namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.CoreMod.Systems.PvE;
    using AtomicTorch.CBND.GameApi;

    public class ZoneTemperateSwamp : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Temperate - Swamp";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            if (!PveSystem.ServerIsPvE)
            {
                // spawn resource deposits on PvP servers
                scripts
                    .Add(GetScript<SpawnDepositOilSeep>().Configure(densityMultiplier: 0.7));
            }

            // minerals
            scripts
                .Add(GetScript<SpawnResourcesGeneric>().Configure(densityMultiplier: 0.30))
                .Add(GetScript<SpawnResourceStone>().Configure(densityMultiplier: 0.1))
                .Add(GetScript<SpawnResourceCoal>().Configure(densityMultiplier: 0.1));

            // trees
            scripts
                .Add(GetScript<SpawnTreesSwamp>());

            // other vegetation
            scripts
                .Add(GetScript<SpawnBushesForestTemperate>().Configure(densityMultiplier: 0.25))
                .Add(GetScript<SpawnMushroomsTemperate>().Configure(densityMultiplier: 0.25))
                .Add(GetScript<SpawnResourceHerbs>().Configure(densityMultiplier: 0.25))
                .Add(GetScript<SpawnSugarcane>().Configure(densityMultiplier: 0.2));

            // swamp exclusive blue herb
            scripts
                .Add(GetScript<SpawnResourceHerbBlue>());

            // loot
            scripts
                .Add(GetScript<SpawnLootGeneric>().Configure(densityMultiplier: 0.5)); // loot (stone, grass, twigs)

            // mobs
            //scripts
            // passive
            //    .Add(GetScript<SpawnMobsRiverSnail>())
            // aggressive
            //    .Add(GetScript<SpawnMobsBlackBeetle>())
            //    .Add(GetScript<SpawnMobsBurrower>())
            //    .Add(GetScript<SpawnMobsSnakeGreen>())
            //    .Add(GetScript<SpawnMobsWildBoar>());

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

			//RiverSnail
			scripts.Add(GetScript<SpawnMobsRiverSnail>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsRiverSnailVariant8>().Configure(densityMultiplier: 0.09));

			//Burrower
			scripts.Add(GetScript<SpawnMobsBurrower>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBurrowerVariant8>().Configure(densityMultiplier: 0.09));

			//BlackBeetle
			scripts.Add(GetScript<SpawnMobsBlackBeetle>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBlackBeetleVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}