namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant0 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant0/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant0/Front");
    }
}