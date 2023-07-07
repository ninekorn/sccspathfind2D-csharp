namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant0 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant0/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant0/Front");
    }
}