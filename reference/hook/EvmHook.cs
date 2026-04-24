using Hedera.Hashgraph.Reference.Contract;

using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Hook
{
    public interface IEvmHook : IEvmHookSpec
    {
        IReadOnlyList<IEvmHookStorageUpdate> StorageUpdates { get; }
    }
    public interface IEvmHook<TSelf> : IEvmHook, IEvmHookSpec<TSelf> where TSelf : IEvmHook<TSelf>
    {
        abstract static TSelf CTOR(IContractId contractId, IReadOnlyList<IEvmHookStorageUpdate> evmHookStorageUpdates);
    }
}
