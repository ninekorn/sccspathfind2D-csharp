namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonBearPolarVariant1 : SkeletonBear
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("BearPolarVariant1/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("BearPolarVariant1/Front");
    }
}