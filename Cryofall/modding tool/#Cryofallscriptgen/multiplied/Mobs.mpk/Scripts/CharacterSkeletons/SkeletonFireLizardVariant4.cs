namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonFireLizardVariant4 : SkeletonCloakedLizard
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("FireLizardVariant4/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("FireLizardVariant4/Front");
    }
}