namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneMobsScorpion : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Mobs - Scorpion";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            //scripts
                // when it's used separately by iself and not in ruins zone - we don't need such a high density, so set it lower
            //    .Add(GetScript<SpawnMobsScorpion>().Configure(densityMultiplier: 0.5));



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

			//Scorpion
			scripts.Add(GetScript<SpawnMobsScorpion>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsScorpionVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}