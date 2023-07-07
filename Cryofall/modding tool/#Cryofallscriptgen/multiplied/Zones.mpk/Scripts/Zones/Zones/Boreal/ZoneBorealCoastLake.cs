namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneBorealCoastLake : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Boreal - Coast - Lake";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals
            scripts
                .Add(GetScript<SpawnResourceSand>().Configure(densityMultiplier: 0.75)); //slightly less sand for lakes

            // loot
            scripts
                .Add(GetScript<SpawnLootStone>());

            // mobs
            //scripts
            //    .Add(GetScript<SpawnMobsCrab>())
            //   .Add(GetScript<SpawnMobsRiverSnail>());

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

			//Crab
			scripts.Add(GetScript<SpawnMobsCrab>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrabVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}