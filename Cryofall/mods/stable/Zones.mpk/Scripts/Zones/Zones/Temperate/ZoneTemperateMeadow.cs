namespace AtomicTorch.CBND.CoreMod.Zones
{
    using AtomicTorch.CBND.GameApi;

    public class ZoneTemperateMeadow : ProtoZoneDefault
    {
        [NotLocalizable]
        public override string Name => "Temperate - Meadow";

        protected override void PrepareZone(ZoneScripts scripts)
        {
            // different vegetation
            scripts
                .Add(GetScript<SpawnBushesForestTemperate>())
                .Add(GetScript<SpawnMushroomsTemperate>())
                // default density for herbs compared to forest, we want them to spawn here a lot
                .Add(GetScript<SpawnResourceHerbs>());

            // loot
            scripts
                .Add(GetScript<SpawnLootGeneric>().Configure(densityMultiplier: 1.35)); // loot (stone, grass, twigs)

            // mobs
            scripts
                .Add(GetScript<SpawnMobsWolf>())
                .Add(GetScript<SpawnMobsChicken>())
                .Add(GetScript<SpawnMobsWildBoar>())
                .Add(GetScript<SpawnMobsSnakeGreen>())
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