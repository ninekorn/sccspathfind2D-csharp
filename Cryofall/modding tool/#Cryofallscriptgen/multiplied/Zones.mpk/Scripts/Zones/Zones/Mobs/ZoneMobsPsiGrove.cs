namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneMobsPsiGrove : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Mobs - Psi grove";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            //scripts
            //    .Add(GetScript<SpawnMobsPsiGrove>());


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

			//PsiGrove
			scripts.Add(GetScript<SpawnMobsPsiGrove>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPsiGroveVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}