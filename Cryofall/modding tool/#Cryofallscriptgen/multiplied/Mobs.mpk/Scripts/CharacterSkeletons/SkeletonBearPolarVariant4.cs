namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant4 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant4/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant4/Front");
    }
}