namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant1 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant1/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant1/Front");
    }
}