namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant7 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant7/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant7/Front");
    }
}