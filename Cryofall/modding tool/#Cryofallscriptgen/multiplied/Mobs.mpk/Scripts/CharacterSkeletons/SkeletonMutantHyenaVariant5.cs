namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant5 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant5/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant5/Front");
    }
}