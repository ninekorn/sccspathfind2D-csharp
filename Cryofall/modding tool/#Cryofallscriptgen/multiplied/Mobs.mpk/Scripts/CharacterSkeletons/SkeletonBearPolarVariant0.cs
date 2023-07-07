namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant0 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant0/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant0/Front");
    }
}