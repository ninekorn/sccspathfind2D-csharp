namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonFireLizardVariant5 : SkeletonCloakedLizard
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("FireLizardVariant5/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("FireLizardVariant5/Front");
    }
}