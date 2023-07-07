namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant5 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant5/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant5/Front");
    }
}