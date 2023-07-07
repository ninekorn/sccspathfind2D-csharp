namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant7 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant7/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant7/Front");
    }
}