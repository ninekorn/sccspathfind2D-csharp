namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonFireLizardVariant1 : SkeletonCloakedLizard
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("FireLizardVariant1/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("FireLizardVariant1/Front");
    }
}