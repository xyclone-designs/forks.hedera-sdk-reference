using Hedera.Hashgraph.Reference.Cryptography;

namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// An ID type that represents a contract on a Hedera Hashgraph network.
    /// </summary>
    public interface IContractId : IKey
    {
        /// <summary>
        /// Serialize the [`ContractId`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();
        string ToString();
        /// <summary>
        /// Serialize the [`ContractId`](ContractId) into its solidity address form.
        /// </summary>
        string ToSolidityAddress();

        /// <summary>
        /// The shard of this ID.
        /// </summary>
        public long Shard { get; }
        /// <summary>
        /// The realm of this ID.
        /// </summary>
        public long Realm { get; }
        /// <summary>
        /// The num of this ID.
        /// </summary>
        public long Num { get; }
    }
    public interface IContractId<TSelf> : IContractId where TSelf : IContractId<TSelf>
    {
        /// <summary>
        /// Construct a [`ContractId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        abstract static TSelf CTOR(long num);
        /// <summary>
        /// Construct a [`ContractId`](#) with all fields explicitly set.
        /// </summary>
        abstract static TSelf CTOR(long shard, long realm, long num);

        /// <summary>
        /// Construct a [`ContractId`](#) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        abstract static TSelf FromString(string str);
        /// <summary>
        /// Deserialize a [`ContractId`](#) from its the protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
        /// <summary>
        /// Construct a [`ContractId`](ContractId) from a shard, realm, and evm address.
        /// </summary>
        abstract static TSelf FromEvmAddress(long shard, long realm, string evmAddress);
        /// <summary>
        /// Construct a [`ContractId`](ContractId) a solidity address.
        ///
        /// Deprecated: Use `fromEvmAddress()` instead.
        /// </summary>
        abstract static TSelf FromSolidityAddress(string str);
    }
}
