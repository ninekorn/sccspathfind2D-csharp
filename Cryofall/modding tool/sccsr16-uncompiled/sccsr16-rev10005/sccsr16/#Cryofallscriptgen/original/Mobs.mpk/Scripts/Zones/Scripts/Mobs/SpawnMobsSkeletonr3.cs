namespace AtomicTorch.CBND.CoreMod.Zones
{
    using System;
    using AtomicTorch.CBND.CoreMod.Characters.Mobs;
    using AtomicTorch.CBND.CoreMod.Triggers;

    public class SpawnMobsSkeletonr3 : ProtoZoneSpawnScript
    {
        protected override void PrepareZoneSpawnScript(Triggers triggers, SpawnList spawnList)
        {
            triggers
                .Add(GetTrigger<TriggerWorldInit>())
                .Add(GetTrigger<TriggerTimeInterval>().ConfigureForSpawn(TimeSpan.FromMinutes(15)));

            spawnList.CreatePreset(interval: 35, padding: 0.5, useSectorDensity: false)
                     .AddExact<MobSkeletonr3>()
                     .SetCustomPaddingWithSelf(40);
        }
    }
}