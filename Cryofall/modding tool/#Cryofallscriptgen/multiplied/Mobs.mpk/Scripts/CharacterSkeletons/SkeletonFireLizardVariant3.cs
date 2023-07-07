namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonFireLizardVariant3 : SkeletonCloakedLizard
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("FireLizardVariant3/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("FireLizardVariant3/Front");
    }
}