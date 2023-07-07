namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant8 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant8/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant8/Front");
    }
}