namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.CoreMod.Systems.Physics;
    using AtomicTorch.CBND.GameApi.Data.Physics;
    using AtomicTorch.CBND.GameApi.Resources;
    using AtomicTorch.CBND.GameApi.ServicesClient.Components;
    using AtomicTorch.GameEngine.Common.Primitives;

    public class SkeletonMutantWolfVariant8 : SkeletonWolf
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantWolfVariant8/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantWolfVariant8/Front");

    }
}