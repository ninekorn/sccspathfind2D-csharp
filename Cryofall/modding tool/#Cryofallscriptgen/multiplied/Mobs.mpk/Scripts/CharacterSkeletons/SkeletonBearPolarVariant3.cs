namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant3 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant3/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant3/Front");
    }
}