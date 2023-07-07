namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant6 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant6/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant6/Front");
    }
}