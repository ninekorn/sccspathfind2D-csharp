namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.CoreMod.Systems.PvE;
    using AtomicTorch.CBND.GameApi;

    public class ZoneTemperateBarren : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Temperate - Barren";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            if (!PveSystem.ServerIsPvE)
            {
                // spawn resource deposits on PvP servers
                scripts
                    .Add(GetScript<SpawnDepositOilSeep>());
            }

            // plants
            scripts
                .Add(GetScript<SpawnTreesBarren>())
                .Add(GetScript<SpawnBushesBarren>())
                .Add(GetScript<SpawnShrubs>());

            // minerals
            scripts
                .Add(GetScript<SpawnResourcePragmium>())
                .Add(GetScript<SpawnResourceCopper>().Configure(densityMultiplier: 0.10))
                .Add(GetScript<SpawnResourceIron>().Configure(densityMultiplier: 0.10))
                .Add(GetScript<SpawnResourceStone>().Configure(densityMultiplier: 0.10))
                .Add(GetScript<SpawnResourceSaltpeter>().Configure(densityMultiplier: 0.10))
                .Add(GetScript<SpawnResourceSulfur>().Configure(densityMultiplier: 0.10));

            // mobs
            scripts
                .Add(GetScript<SpawnMobsCloakedLizard>().Configure(densityMultiplier: 0.5))
                .Add(GetScript<SpawnMobsHoneyBadger>())
                .Add(GetScript<SpawnMobsPangolin>())
                .Add(GetScript<SpawnMobsSnakeBrown>())
                .Add(GetScript<SpawnMobsHyena>())
                .Add(GetScript<SpawnMobsThumper>())
                // mutants
                .Add(GetScript<SpawnMobsMutantHyena>())
              .Add(GetScript<SpawnMobsSkeleton>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant0>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant1>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant2>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant3>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant4>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant5>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant6>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant7>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsSkeletonVariant8>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombie>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant0>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant1>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant2>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant3>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant4>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant5>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant6>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant7>().Configure(densityMultiplier: 0.2))
                .Add(GetScript<SpawnMobsZombieVariant8>().Configure(densityMultiplier: 0.2));
        }
    }
}