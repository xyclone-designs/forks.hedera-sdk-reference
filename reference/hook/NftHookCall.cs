
namespace Hedera.Hashgraph.Reference.Hook
{
    public interface INftHookCall : IHookCall
    {
        FungibleHookType HookType { get; }
    }
    public interface INftHookCall<TSelf> : INftHookCall, IHookCall<TSelf> where TSelf : INftHookCall<TSelf>
    {
        abstract static TSelf CTOR(long hookId, IEvmHookCall evmHookCall, NftHookType hookType);
    }
}
