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
            //scripts
            //    .Add(GetScript<SpawnMobsCloakedLizard>().Configure(densityMultiplier: 0.5))
            //    .Add(GetScript<SpawnMobsHoneyBadger>())
            //    .Add(GetScript<SpawnMobsPangolin>())
            //    .Add(GetScript<SpawnMobsSnakeBrown>())
            //    .Add(GetScript<SpawnMobsHyena>())
            //    .Add(GetScript<SpawnMobsThumper>())
            // mutants
            //    .Add(GetScript<SpawnMobsMutantHyena>());

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

			//SnakeBrown
			scripts.Add(GetScript<SpawnMobsSnakeBrown>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsSnakeBrownVariant8>().Configure(densityMultiplier: 0.09));

			//Pangolin
			scripts.Add(GetScript<SpawnMobsPangolin>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsPangolinVariant8>().Configure(densityMultiplier: 0.09));

			//MutantHyena
			scripts.Add(GetScript<SpawnMobsMutantHyena>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsMutantHyenaVariant8>().Configure(densityMultiplier: 0.09));

			//Hyena
			scripts.Add(GetScript<SpawnMobsHyena>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHyenaVariant8>().Configure(densityMultiplier: 0.09));

			//HoneyBadger
			scripts.Add(GetScript<SpawnMobsHoneyBadger>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsHoneyBadgerVariant8>().Configure(densityMultiplier: 0.09));

			//CloakedLizard
			scripts.Add(GetScript<SpawnMobsCloakedLizard>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant0>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant1>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant2>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant3>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant4>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant5>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant6>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant7>().Configure(densityMultiplier: 0.09))
			.Add(GetScript<SpawnMobsCloakedLizardVariant8>().Configure(densityMultiplier: 0.09));

        }
    }
}