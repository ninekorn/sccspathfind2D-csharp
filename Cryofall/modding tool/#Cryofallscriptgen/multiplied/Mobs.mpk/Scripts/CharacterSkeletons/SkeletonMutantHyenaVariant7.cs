namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant7 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant7/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant7/Front");
    }
}