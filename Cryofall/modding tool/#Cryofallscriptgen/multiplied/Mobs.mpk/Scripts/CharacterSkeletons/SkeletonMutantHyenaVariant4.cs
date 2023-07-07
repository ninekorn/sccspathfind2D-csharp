namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonMutantHyenaVariant4 : SkeletonHyena
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantHyenaVariant4/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantHyenaVariant4/Front");
    }
}