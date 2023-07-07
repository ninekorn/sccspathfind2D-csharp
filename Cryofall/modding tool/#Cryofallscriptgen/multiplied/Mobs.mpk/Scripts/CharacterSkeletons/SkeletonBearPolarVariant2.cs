namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant2 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant2/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant2/Front");
    }
}