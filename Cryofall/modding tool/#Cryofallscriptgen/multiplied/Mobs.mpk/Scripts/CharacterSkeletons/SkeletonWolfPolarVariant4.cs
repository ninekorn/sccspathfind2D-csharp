namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.GameApi.Resources;

    public class SkeletonWolfPolarVariant4 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("WolfPolarVariant4/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("WolfPolarVariant4/Front");
    }
}