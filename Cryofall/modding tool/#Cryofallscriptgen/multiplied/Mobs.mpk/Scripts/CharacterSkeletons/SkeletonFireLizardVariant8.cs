namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonFireLizardVariant8 : SkeletonCloakedLizard
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("FireLizardVariant8/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("FireLizardVariant8/Front");
    }
}