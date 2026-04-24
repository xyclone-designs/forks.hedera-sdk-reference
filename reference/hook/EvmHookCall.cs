
namespace Hedera.Hashgraph.Reference.Hook
{
    public interface IEvmHookCall
    {
        long HookId { get; }
        IEvmHookCall EvmHookCall { get; }
    }
    public interface IEvmHookCall<TSelf> : IEvmHookCall where TSelf : IEvmHookCall<TSelf>
    {
        abstract static TSelf CTOR(long hookId, IEvmHookCall evmHookCall);
    }
}
