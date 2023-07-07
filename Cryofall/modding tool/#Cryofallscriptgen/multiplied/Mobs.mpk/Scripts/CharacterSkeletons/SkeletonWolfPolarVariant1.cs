namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant1 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant1/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant1/Front");
    }
}