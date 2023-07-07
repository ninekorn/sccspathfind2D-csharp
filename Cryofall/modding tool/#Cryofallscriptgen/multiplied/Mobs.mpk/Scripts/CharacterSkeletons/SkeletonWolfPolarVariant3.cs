namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant3 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant3/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant3/Front");
    }
}