namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant2 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant2/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant2/Front");
    }
}