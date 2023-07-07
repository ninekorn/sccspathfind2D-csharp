namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant5 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant5/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant5/Front");
    }
}