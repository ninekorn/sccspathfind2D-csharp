namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant3 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant3/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant3/Front");
    }
}