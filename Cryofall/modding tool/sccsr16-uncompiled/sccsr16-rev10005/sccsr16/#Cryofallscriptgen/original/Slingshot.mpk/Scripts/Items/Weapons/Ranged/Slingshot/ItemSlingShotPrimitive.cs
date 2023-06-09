﻿namespace AtomicTorch.CBND.CoreMod.Items.Weapons.Ranged
{
    using System.Collections.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Ammo;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.GameApi.Data.Weapons;

    public class ItemSlingshotPrimitive : ProtoItemBow
    {
        public override ushort AmmoCapacity => 1;

        public override double AmmoReloadDuration => 1.75; //2.75

        public override string CharacterAnimationAimingName => "WeaponPistolAiming";

        public override double CharacterAnimationAimingRecoilDuration => 0.6;

        public override string CharacterAnimationAimingRecoilName => "WeaponPistolShooting";

        public override double CharacterAnimationAimingRecoilPower => 0.75;

        public override string Description => "Technology from the old times. Still works as well as before.";

        public override uint DurabilityMax => 500;

        public override double FireInterval => 0; // can fire as soon as reloaded

        public override string Name => "Slingshot Primitive"; //Crossbow

        public override double SkeletonPreviewOffsetX => 270;

        public override (float min, float max) SoundPresetWeaponDistance
            => (SoundConstants.AudioListenerMinDistanceRangedShot,
                SoundConstants.AudioListenerMaxDistanceRangedShotBows);

        public override double SpecialEffectProbability => 0.50; //0.25

        public override double TimeToReadyAfterReloading => 0.10; //0.25

        protected override ProtoSkillWeapons WeaponSkill => null;

        protected override void PrepareMuzzleFlashDescription(MuzzleFlashDescription description)
        {
            description.Set(MuzzleFlashPresets.None)
                       .Set(textureScreenOffset: (231, 58));
        }

        protected override void PrepareProtoWeaponBow(
            out IEnumerable<IProtoItemAmmo> compatibleAmmoProtos,
            ref DamageDescription overrideDamageDescription)
        {
            compatibleAmmoProtos = GetAmmoOfType<IAmmoThrowingStone>(); //IAmmoArrow
        }

        protected override ReadOnlySoundPreset<WeaponSound> PrepareSoundPresetWeapon()
        {
            return WeaponsSoundPresets.WeaponRangedBow;
        }

        protected override void ServerOnSpecialEffect(ICharacter damagedCharacter, double damage)
        {
            ServerWeaponSpecialEffectsHelper.OnFirearmHit(damagedCharacter, damage);
        }
    }
}