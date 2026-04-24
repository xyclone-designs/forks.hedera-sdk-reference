
namespace Hedera.Hashgraph.Reference.Hook
{
    public interface IEvmHookMappingEntry
    {
        bool HasExplicitKey { get; }
        bool HasPreimageKey { get; }
        byte[]? Key { get; }
        byte[]? PreImage { get; }
        byte[] Value { get; }
    }
    public interface IEvmHookMappingEntry<TSelf> where TSelf : IEvmHookMappingEntry<TSelf>
    {
        abstract static TSelf CTOR(byte[]? key, byte[]? preimage, byte[] value);

        abstract static TSelf OfKey(byte[] key, byte[] value);
        abstract static TSelf WithPreimage(byte[] preimage, byte[] value);
    }
}
