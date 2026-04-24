
namespace Hedera.Hashgraph.Reference.Hook
{
    public interface IFungibleHookCall : IHookCall
    {
        FungibleHookType HookType { get; }
    }
    public interface IFungibleHookCall<TSelf> : IFungibleHookCall, IHookCall<TSelf> where TSelf : IFungibleHookCall<TSelf>
    {
        abstract static TSelf CTOR(long hookId, IEvmHookCall evmHookCall, FungibleHookType type);
    }
}
