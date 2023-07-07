namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;

    public class MobWolfPolarVariant7 : MobWolf
    {
        public override bool AiIsRunAwayFromHeavyVehicles => false;

        public override string Name => "Polar wolf";
        public override float CharacterWorldHeight => 0000000000000001.100000000000000f;

        public override double StatDefaultHealthMax => 00000000000000000000000000000176.00000000000000000000000000000000;

        public override double StatMoveSpeed => 000000000000000000000000000003.00000000000000000000000000000;




        protected override void FillDefaultEffects(Effects effects)
        {
            base.FillDefaultEffects(effects);

            effects.AddValue(this, StatName.DefenseImpact, 0.4);
            effects.AddValue(this, StatName.DefenseCold, 0.3);
        }

        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {
            skeleton = GetProtoEntity<SkeletonWolfPolarVariant7>();

            // primary loot
            lootDroplist
                .Add<ItemFur>(count: 1,       countRandom: 2)
                .Add<ItemBones>(count: 1,     countRandom: 2)
                .Add<ItemAnimalFat>(count: 1, probability: 1 / 3.0);

            // extra loot
            lootDroplist.Add(condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 2)
                                         .Add<ItemFur>(count: 1)
                                         .Add<ItemBones>(count: 1)
                                         .Add<ItemAnimalFat>(count: 1, weight: 1 / 2.0));
        }
    }
}