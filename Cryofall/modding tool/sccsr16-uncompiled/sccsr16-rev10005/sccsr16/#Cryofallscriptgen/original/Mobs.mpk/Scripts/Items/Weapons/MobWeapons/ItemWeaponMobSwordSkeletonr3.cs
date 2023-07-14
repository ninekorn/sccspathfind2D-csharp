namespace AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons
{
    using System;
    using System.Collections.Generic;
    using AtomicTorch.CBND.CoreMod.CharacterStatusEffects;
    using AtomicTorch.CBND.CoreMod.CharacterStatusEffects.Debuffs;
    using AtomicTorch.CBND.CoreMod.Items.Ammo;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.GameApi.Data.Weapons;
    using AtomicTorch.GameEngine.Common.Helpers;

    public class ItemWeaponMobSwordSkeletonr3 : ProtoItemMobWeaponMelee
    {
        public override bool CanDamageStructures => true;

        public override string Description => "Skeleton Sword";

        public override double DamageApplyDelay => 0; //0.15

        public override double FireAnimationDuration => 1.2; //0.6

        public override double FireInterval => this.FireAnimationDuration * 1.5; //1.5

        public override string Name => this.ShortId;


        public static float getSomeRandNumThousandDecimalfloat(float minNum, float maxNum, int dontfloor, float thedecimalmul)
        {
            System.Random randomer0 = new System.Random();

            float num = 0;

            if (dontfloor == -1)
            {
                num = (float)((randomer0.NextDouble() * maxNum)); // this will get a number between 1 and 999;

                /*if (autonegative == 1)
                {
                    num *= (randomer0.NextDouble() * 2) == 1 ? 1 : -1; // this will add minus sign in 50% of cases
                }*/
            }
            else
            {
                num = (float)(Math.Floor(randomer0.NextDouble() * maxNum) + minNum); // this will get a number between 1 and 999;

                /*if (autonegative == 1)
                {
                    num *= Math.Floor(randomer0.NextDouble() * 2) == 1 ? 1 : -1; // this will add minus sign in 50% of cases
                }*/
            }

            /*
            if (dontfloor == -1)
            {
                return (float)(num);
            }
            else
            {
                return (float)(num * _decimal);

            }*/
            return (num * thedecimalmul); // 0.000000001

        }




        protected override void PrepareProtoWeapon(
            out IEnumerable<IProtoItemAmmo> compatibleAmmoProtos,
            ref DamageDescription overrideDamageDescription)
        {

            double damageval = (double)getSomeRandNumThousandDecimalfloat(3.0f, 12.0f, -1, 1);
            double armorpiercingcoef = (double)getSomeRandNumThousandDecimalfloat(0.075f, 0.125f, -1, 1);
            //double finalDamageMultiplier = (double)getSomeRandNumThousandDecimalfloat(0.95f, 1.05f, -1, 1);
            double rangeMax = (double)getSomeRandNumThousandDecimalfloat(1.3f, 1.5f, -1, 1);

            // no ammo used
            compatibleAmmoProtos = null;

            var damageDistribution = new DamageDistribution();
            damageDistribution.Set(DamageType.Impact, 1.0);

            overrideDamageDescription = new DamageDescription(
                damageValue: damageval,
                armorPiercingCoef: armorpiercingcoef,
                finalDamageMultiplier: 1,
                rangeMax: 1.4,
                damageDistribution: damageDistribution);
        }



        protected override ReadOnlySoundPreset<ObjectMaterial> PrepareSoundPresetHit()
        {
            return MaterialHitsSoundPresets.MeleeNoWeapon;
        }


        protected override void ServerOnSpecialEffect(ICharacter damagedCharacter, double damage)
        {
            double RollWithProbabilitydouble0 = (double)getSomeRandNumThousandDecimalfloat(0.15f, 0.35f, -1, 1);
            double RollWithProbabilitydouble1 = (double)getSomeRandNumThousandDecimalfloat(0.075f, 0.125f, -1, 1);

            double StatusEffectBleedingdouble = (double)getSomeRandNumThousandDecimalfloat(0.075f, 0.125f, -1, 1);
            double StatusEffectPaindouble = (double)getSomeRandNumThousandDecimalfloat(0.3f, 0.5f, -1, 1);
            double StatusEffectDazeddouble = (double)getSomeRandNumThousandDecimalfloat(0.3f, 0.5f, -1, 1);

            if (RandomHelper.RollWithProbability(RollWithProbabilitydouble0))
            {
                damagedCharacter.ServerAddStatusEffect<StatusEffectBleeding>(intensity: StatusEffectBleedingdouble);
                damagedCharacter.ServerAddStatusEffect<StatusEffectPain>(intensity: StatusEffectPaindouble);
            }

            if (RandomHelper.RollWithProbability(RollWithProbabilitydouble1))
            {
                damagedCharacter.ServerAddStatusEffect<StatusEffectDazed>(intensity: StatusEffectDazeddouble);
            }
        }
    }
}














/*
namespace AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons
{
    using System.Collections.Generic;
    using AtomicTorch.CBND.CoreMod.CharacterStatusEffects;
    using AtomicTorch.CBND.CoreMod.CharacterStatusEffects.Debuffs;
    using AtomicTorch.CBND.CoreMod.Items.Ammo;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.GameApi.Data.Items;
    using AtomicTorch.CBND.GameApi.Data.Weapons;
    using AtomicTorch.CBND.GameApi.Data.World;
    using AtomicTorch.CBND.GameApi.Resources;
    using AtomicTorch.CBND.GameApi.Scripting.ClientComponents;
    using AtomicTorch.CBND.GameApi.ServicesClient.Components;
    using AtomicTorch.CBND.CoreMod.Systems.Weapons;
    using AtomicTorch.GameEngine.Common.Helpers;

    public class ItemWeaponSkeletonSword : ProtoItemMobWeaponMelee
    {
        public override bool CanDamageStructures => true;

        public override string Description => null;

        public override uint DurabilityMax => 0;

        public override double DamageApplyDelay => 0;

        public override double FireAnimationDuration => 1.2;
        public override double FireInterval => 2.0;

        //public override ITextureResource Icon => null;

        public override string Name => this.ShortId;

        public override double SpecialEffectProbability =>
            1; // Must always be 1 for all animal weapons. Individual effects will be rolled in the effect function.

        protected override TextureResource WeaponTextureResource => null;

        //public override void ClientSetupSkeleton(
        //    IItem item,
        //    ICharacter character,
        //    IComponentSkeleton skeletonRenderer,
        //    List<IClientComponent> skeletonComponents)
        //{
        //    // do nothing
        //}

        protected override void PrepareProtoWeapon(
            out IEnumerable<IProtoItemAmmo> compatibleAmmoProtos,
            ref DamageDescription overrideDamageDescription)
        {
            // no ammo used
            compatibleAmmoProtos = null;

            var damageDistribution = new DamageDistribution();
            damageDistribution.Set(DamageType.Impact, 1.0);

            overrideDamageDescription = new DamageDescription(
                damageValue: 12,
                armorPiercingCoef: 0.1,
                finalDamageMultiplier: 1,
                rangeMax: 1.4,
                damageDistribution: damageDistribution);
        }

        protected override ReadOnlySoundPreset<WeaponSound> PrepareSoundPresetWeapon()
        {
            return WeaponsSoundPresets.SpecialUseSkeletonSound;
        }

        protected override void ServerOnSpecialEffect(ICharacter damagedCharacter, double damage)
        {
            if (RandomHelper.RollWithProbability(0.25))
            {
                damagedCharacter.ServerAddStatusEffect<StatusEffectBleeding>(intensity: 0.1);
                damagedCharacter.ServerAddStatusEffect<StatusEffectPain>(intensity: 0.4);
            }

            if (RandomHelper.RollWithProbability(0.1))
            {
                damagedCharacter.ServerAddStatusEffect<StatusEffectDazed>(intensity: 0.4);
            }
        }
    }
}*/