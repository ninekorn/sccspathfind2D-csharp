namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant6 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant6/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant6/Front");
    }
}