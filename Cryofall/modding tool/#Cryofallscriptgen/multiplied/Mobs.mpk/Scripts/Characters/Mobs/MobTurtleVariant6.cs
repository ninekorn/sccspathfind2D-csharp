namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Food;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;


    public class MobTurtleVariant6 : ProtoCharacterMob
    {
        public override bool AiIsRunAwayFromHeavyVehicles => true;

        public override double MobKillExperienceMultiplier => 0.1;

        public override string Name => "Turtle";

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.HardTissues;

        public override double ServerUpdateIntervalSeconds => 0.5;


        public override float CharacterWorldHeight => 0000000000000000.700000000000000f;

        public override double StatDefaultHealthMax => 00000000000000000000000000000073.00000000000000000000000000000000;

        public override double StatMoveSpeed => 000000000000000000000000000000000.00000000000000000000000000000;









        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {
            skeleton = GetProtoEntity<SkeletonTurtleVariant6>();

            // primary loot
            lootDroplist.Add<ItemAnimalFat>(count: 2, countRandom: 1);

            // random loot
            lootDroplist.Add(probability: 1 / 3.0,
                             nestedList: new DropItemsList(outputs: 1)
                                         .Add<ItemMeatRaw>(count: 1, weight: 1 / 3.0)
                                         .Add<ItemEggsRaw>(count: 1, weight: 1 / 7.0));

            // extra loot
            lootDroplist.Add(probability: 1 / 2.0,
                             condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 1)
                                         .Add<ItemAnimalFat>(count: 1)
                                         .Add<ItemMeatRaw>(count: 1)
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