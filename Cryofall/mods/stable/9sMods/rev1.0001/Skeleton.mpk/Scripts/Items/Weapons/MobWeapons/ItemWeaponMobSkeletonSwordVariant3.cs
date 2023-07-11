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
    using AtomicTorch.CBND.GameApi.Resources;
    using AtomicTorch.CBND.GameApi.Scripting.ClientComponents;
    using AtomicTorch.CBND.GameApi.ServicesClient.Components;
    using AtomicTorch.GameEngine.Common.Helpers;

    public class ItemWeaponMobSkeletonSwordVariant3 : ProtoItemWeaponMelee
    {
        public override double DamageApplyDelay => 0.15;

        public override double FireAnimationDuration => 0.6;

        public override bool CanDamageStructures => true;

        public override string Description => null;

        public override uint DurabilityMax => 0;

        //public override ITextureResource Icon => null;

        public override string Name => this.ShortId;

        public override double SpecialEffectProbability =>
            1; // Must always be 1 for all animal weapons. Individual effects will be rolled in the effect function.

        protected override TextureResource WeaponTextureResource => null;

        /*public override void ClientSetupSkeleton(
            IItem item,
            ICharacter character,
            IComponentSkeleton skeletonRenderer,
            List<IClientComponent> skeletonComponents)
        {
            // do nothing
        }*/

        protected override void PrepareProtoWeapon(
            out IEnumerable<IProtoItemAmmo> compatibleAmmoProtos,
            ref DamageDescription overrideDamageDescription)
        {
            // no ammo used
            compatibleAmmoProtos = null;

            var damageDistribution = new DamageDistribution();
            damageDistribution.Set(DamageType.Impact,   1.0);

            overrideDamageDescription = new DamageDescription(
                damageValue: 12,
                armorPiercingCoef: 0.1,
                finalDamageMultiplier: 1,
                rangeMax: 1.2,
                damageDistribution: damageDistribution);
        }

        protected override ReadOnlySoundPreset<WeaponSound> PrepareSoundPresetWeapon()
        {
            return WeaponsSoundPresets.SpecialUseSkeletonSound;
        }

        protected override void ServerOnSpecialEffect(ICharacter damagedCharacter, double damage)
        {
            if (RandomHelper.RollWithProbability(0.7))
            {
                damagedCharacter.ServerAddStatusEffect<StatusEffectBleeding>(intensity: 0.1);
                damagedCharacter.ServerAddStatusEffect<StatusEffectPain>(intensity: 0.4);
            }

            if (RandomHelper.RollWithProbability(0.1))
            {
                damagedCharacter.ServerAddStatusEffect<StatusEffectBrokenLeg>(intensity: 1);
            }
        }
    }
}