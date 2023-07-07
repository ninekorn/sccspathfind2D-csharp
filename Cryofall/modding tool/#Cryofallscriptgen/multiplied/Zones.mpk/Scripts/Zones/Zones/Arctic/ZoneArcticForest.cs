namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneArcticForest : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Arctic - Forest";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // no pvp resources spawn, this area is a quiet "haven"

            // minerals
            scripts
                .Add(GetScript<SpawnResourceStone>().Configure(densityMultiplier: 0.15));

            // trees
            scripts
                .Add(GetScript<SpawnTreesArctic>());

            // loot
            scripts
                .Add(GetScript<SpawnLootPileWood>())
                .Add(GetScript<SpawnLootPileStone>().Configure(densityMultiplier: 0.2));

            // mobs
            //scripts
            //    .Add(GetScript<SpawnMobsWolfPolar>())
            //    .Add(GetScript<SpawnMobsBearPolar>())
            //    .Add(GetScript<SpawnMobsBroodNest>());

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

			//WolfPolar
			scripts.Add(GetScript<SpawnMobsWolfPolar>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsWolfPolarVariant8>().Configure(densityMultiplier: 0.09));

			//BroodNest
			scripts.Add(GetScript<SpawnMobsBroodNest>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBroodNestVariant8>().Configure(densityMultiplier: 0.09));

			//BearPolar
			scripts.Add(GetScript<SpawnMobsBearPolar>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsBearPolarVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}