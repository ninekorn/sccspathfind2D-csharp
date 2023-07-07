namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant2 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant2/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant2/Front");
    }
}