namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneMobsSpitter : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Mobs - Spitters";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            //scripts
            //    .Add(GetScript<SpawnMobsSpitter>());

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

			//Spitter
			scripts.Add(GetScript<SpawnMobsSpitter>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSpitterVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}