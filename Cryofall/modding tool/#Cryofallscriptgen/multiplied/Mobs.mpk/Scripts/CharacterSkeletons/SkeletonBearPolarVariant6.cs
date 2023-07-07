namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant6 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant6/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant6/Front");
    }
}