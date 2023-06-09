namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;
    using AtomicTorch.CBND.GameApi.ServicesClient.Components;

    public class SkeletonSkeletonVariant1 : ProtoCharacterSkeletonHuman// SkeletonHuman
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new SkeletonResource("SkeletonVariant1/MaleBack");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new SkeletonResource("SkeletonVariant1/MaleFront");

        public override double WorldScale => 0.165;

        public override void ClientSetupShadowRenderer(IComponentSpriteRenderer shadowRenderer, double scaleMultiplier)
        {
            shadowRenderer.PositionOffset = (0, -0.06 * scaleMultiplier);
            shadowRenderer.Scale = 0.7 * scaleMultiplier;
        }
    }
}







/*namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.CoreMod.Systems.Physics;
    using AtomicTorch.CBND.GameApi.Data.Physics;
    using AtomicTorch.CBND.GameApi.ServicesClient.Components;

    public class SkeletonSkeletonVariant1 : ProtoCharacterSkeleton
    {

        public override SkeletonResource SkeletonResourceBack { get; }
    = new SkeletonResource("SkeletonVariant1/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new SkeletonResource("SkeletonVariant1/Front");
        public override void ClientSetupShadowRenderer(IComponentSpriteRenderer shadowRenderer, double scaleMultiplier)
        {
            shadowRenderer.PositionOffset = (0, -0.15 * scaleMultiplier);
            shadowRenderer.Scale = 1.75 * scaleMultiplier;
        }



        public const double MeleeHitboxHeight = 0.7;

        public const double MeleeHitboxOffset = 0.25;

        public const double RangedHitboxHeight = 1.4;

        public const double RangedHitboxOffset = 0;

        public override double DefaultMoveSpeed => 1.5;

        public override bool HasMoveStartAnimations => true;

        public override float OrientationDownExtraAngle => 35;

        public override float OrientationThresholdDownHorizontalFlipDeg => 25;

        public override float OrientationThresholdDownToUpFlipDeg => 45;

        public override float OrientationThresholdUpHorizontalFlipDeg => 20;

        public override double SpeedMultiplier => 1;

        public override double WorldScale => 0.15;

        protected override string SoundsFolderPath => "Skeletons/Scorpion";

        public override void CreatePhysics(IPhysicsBody physicsBody)
        {
            // human legs collider
            var radius = 0.2;

            physicsBody.AddShapeCircle(
                radius / 2,
                center: (-radius / 2, 0));

            physicsBody.AddShapeCircle(
                radius / 2,
                center: (radius / 2, 0));

            physicsBody.AddShapeRectangle(
                size: (radius, radius),
                offset: (-radius / 2, -radius / 2));

            // melee hitbox
            physicsBody.AddShapeRectangle(
                size: (0.6, MeleeHitboxHeight),
                offset: (-0.3, MeleeHitboxOffset),
                group: CollisionGroups.HitboxMelee);

            // ranged hitbox
            physicsBody.AddShapeRectangle(
                size: (0.5, RangedHitboxHeight),
                offset: (-0.25, RangedHitboxOffset),
                group: CollisionGroups.HitboxRanged);
        }

        public override void OnSkeletonCreated(IComponentSkeleton skeleton)
        {
            base.OnSkeletonCreated(skeleton);

            //skeleton.SetMixDuration("Torch", 0.3f);
        }
    }
}*/
