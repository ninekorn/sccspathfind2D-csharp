﻿namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Food;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;

    public class MobChicken : ProtoCharacterMob
    {
        public override bool AiIsRunAwayFromHeavyVehicles => true;


        public override double MobKillExperienceMultiplier => 0.1;

        public override string Name => "Chicken";

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.SoftTissues;

        public override double ServerUpdateIntervalSeconds => 0.5;

        public override float CharacterWorldHeight => 0000000000000000.7000000000000000f;

        public override double StatDefaultHealthMax => 00000000000000000000000000000039.00000000000000000000000000000000;

        public override double StatMoveSpeed => 00000000000000000000000000000001.72500000000000000000000000000000;


        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {
            skeleton = GetProtoEntity<SkeletonChicken>();

            // random loot
            lootDroplist.Add(nestedList: new DropItemsList(outputs: 1)
                                         .Add<ItemMeatRaw>(count: 1, weight: 1 / 2.0)
                                         .Add<ItemEggsRaw>(count: 1));

            // extra loot
            lootDroplist.Add(condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 1)
                                         .Add<ItemMeatRaw>(count: 1, weight: 1 / 2.0)
                                         .Add<ItemEggsRaw>(count: 1));
        }

        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            var character = data.GameObject;

            ServerCharacterAiHelper.ProcessRetreatingAi(
                character,
                distanceRetreat: 5,
                out var movementDirection,
                out var rotationAngleRad);

            this.ServerSetMobInput(character, movementDirection, rotationAngleRad);
        }
    }
}