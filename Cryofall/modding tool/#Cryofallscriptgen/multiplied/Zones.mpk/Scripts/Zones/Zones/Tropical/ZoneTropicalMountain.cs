namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneTropicalMountain : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Tropical - Mountain";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // minerals
            scripts
                .Add(GetScript<SpawnResourceCopper>())
                .Add(GetScript<SpawnResourceIron>())
                .Add(GetScript<SpawnResourceStone>())
                .Add(GetScript<SpawnResourceCoal>().Configure(densityMultiplier: 0.7)) // less coal than boreal, but still still available
                .Add(GetScript<SpawnResourceSaltpeter>())
                .Add(GetScript<SpawnResourceSulfur>());

            // loot
            scripts
                .Add(GetScript<SpawnLootPileMinerals>());

            // mobs
            //scripts
            //    .Add(GetScript<SpawnMobsCrawler>());

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

			//Crawler
			scripts.Add(GetScript<SpawnMobsCrawler>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCrawlerVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}