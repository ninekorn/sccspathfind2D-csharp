namespace AtomicTorch.CBND.CoreMod.CharacterSkeletons
{
    using AtomicTorch.CBND.CoreMod.Systems.Physics;
    using AtomicTorch.CBND.GameApi.Data.Physics;
    using AtomicTorch.CBND.GameApi.Resources;
    using AtomicTorch.CBND.GameApi.ServicesClient.Components;
    using AtomicTorch.GameEngine.Common.Primitives;

    public class SkeletonMutantBoarVariant6 : SkeletonWildBoar
    {
        public override SkeletonResource SkeletonResourceBack { get; }
            = new("MutantBoarVariant6/Back");

        public override SkeletonResource SkeletonResourceFront { get; }
            = new("MutantBoarVariant6/Front");

    }
}