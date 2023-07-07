namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant8 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant8/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant8/Front");
    }
}