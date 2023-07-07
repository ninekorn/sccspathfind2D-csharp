namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneTemperateCoastOcean : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Temperate - Coast - Ocean";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals
            scripts
                .Add(GetScript<SpawnResourceSand>());

            // loot
            scripts
                .Add(GetScript<SpawnLootStone>());

            // mobs
            //scripts
            //    .Add(GetScript<SpawnMobsCrab>().Configure(densityMultiplier: 0.8))
            //    .Add(GetScript<SpawnMobsStarfish>())
            //    .Add(GetScript<SpawnMobsTurtle>());

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

			//Turtle
			scripts.Add(GetScript<SpawnMobsTurtle>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsTurtleVariant8>().Configure(densityMultiplier: 0.09));

			//Starfish
			scripts.Add(GetScript<SpawnMobsStarfish>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsStarfishVariant8>().Configure(densityMultiplier: 0.09));

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