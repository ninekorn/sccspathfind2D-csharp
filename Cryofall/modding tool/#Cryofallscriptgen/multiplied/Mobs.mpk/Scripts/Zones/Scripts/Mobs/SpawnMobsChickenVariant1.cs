namespace AtomicTorch.CBND.CoreMod.Zones
{
    using System;
    using AtomicTorch.CBND.CoreMod.Characters.Mobs;
    using AtomicTorch.CBND.CoreMod.Triggers;

    public class SpawnMobsChickenVariant1 : ProtoZoneSpawnScript
    {
        protected override void PrepareZoneSpawnScript(Triggers triggers, SpawnList spawnList)
        {
            triggers
                .Add(GetTrigger<TriggerWorldInit>())
                .Add(GetTrigger<TriggerTimeInterval>().ConfigureForSpawn(TimeSpan.FromMinutes(5)));

            spawnList.CreatePreset(interval: 25, padding: 0.5, useSectorDensity: false)
                     .AddExact<MobChickenVariant1>()
                     .SetCustomPaddingWithSelf(35);
        }
    }
}