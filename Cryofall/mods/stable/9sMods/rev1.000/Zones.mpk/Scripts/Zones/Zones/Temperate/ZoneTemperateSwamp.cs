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
            scripts
                // passive
                .Add(GetScript<SpawnMobsRiverSnail>())
                // aggressive
                .Add(GetScript<SpawnMobsBlackBeetle>())
                .Add(GetScript<SpawnMobsBurrower>())
                .Add(GetScript<SpawnMobsSnakeGreen>())
                .Add(GetScript<SpawnMobsWildBoar>())
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