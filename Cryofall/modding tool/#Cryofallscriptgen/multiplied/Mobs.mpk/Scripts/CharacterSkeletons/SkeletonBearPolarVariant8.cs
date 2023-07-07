namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant8 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant8/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant8/Front");
    }
}