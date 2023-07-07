namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Food;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;


    public class MobBearPolarVariant6 : MobBear
    {
        public override bool AiIsRunAwayFromHeavyVehicles => false;

        public override string Name => "Polar bear";
        public override float CharacterWorldHeight => 0000000000000001.3000000000000000f;

        public override double StatDefaultHealthMax => 00000000000000000000000000000427.00000000000000000000000000000000;

        public override double StatMoveSpeed => 000000000000000000000000000003.00000000000000000000000000000;

        protected override void FillDefaultEffects(Effects effects)
        {
            base.FillDefaultEffects(effects);

            effects.AddValue(this, StatName.DefenseImpact, 0.6);
            effects.AddValue(this, StatName.DefenseCold, 0.5);
        }

        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {
            skeleton = GetProtoEntity<SkeletonBearPolarVariant6>();

            // primary loot
            lootDroplist
                .Add<ItemMeatRaw>(count: 2)
                .Add<ItemFur>(count: 2,       countRandom: 2)
                .Add<ItemAnimalFat>(count: 2, countRandom: 1)
                .Add<ItemBones>(count: 2,     countRandom: 1);

            // chance for extra loot (2 bonus items)
            lootDroplist.Add(condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 2)
                                         .Add<ItemMeatRaw>(count: 1)
                                         .Add<ItemFur>(count: 1)
                                         .Add<ItemAnimalFat>(count: 1)
                                         .Add<ItemBones>(count: 1));
        }
    }
}