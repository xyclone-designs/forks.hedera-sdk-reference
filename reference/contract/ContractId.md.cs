namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// An ID type that represents a contract on a Hedera Hashgraph network.
    ///
    /// </summary>
    public interface IContractId
    {
        /// <summary>
        ///
        /// Construct a [`ContractId`](ContractId) with [`shard`](#shard--uint64) and [`realm`](#realm--uint64) being zero.
        ///
        ///
        /// </summary>
        abstract static void Constructor(long num)

        /// <summary>
        ///
        /// Construct a [`ContractId`](ContractId) with all fields explicitly set.
        ///
        ///
        /// </summary>
        abstract static void Constructor(long shard, long realm, long num)

        /// <summary>
        ///
        /// Deserialize a [`ContractId`](ContractId) from its protobuf representation.
        ///
        ///
        /// </summary>
        abstract static IContractId FromBytes(byte[] data)

        /// <summary>
        ///
        /// Construct a [`ContractId`](ContractId) from a shard, realm, and evm address.
        ///
        ///
        /// </summary>
        abstract static IContractId FromEvmAddress(long shard, long realm, string evmAddress)

        /// <summary>
        ///
        /// Construct a [`ContractId`](ContractId) a solidity address.
        ///
        /// Deprecated: Use `fromEvmAddress()` instead.
        ///
        ///
        /// </summary>
        abstract static IContractId FromSolidityAddress(string str)

        /// <summary>
        ///
        /// Construct a [`ContractId`](ContractId) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        ///
        ///
        /// </summary>
        abstract static IContractId FromString(string str)

        /// <summary>
        ///
        /// Serialize the [`ContractId`](ContractId) into its protobuf representation.
        ///
        ///
        /// </summary>
        byte[] ToBytes()

        /// <summary>
        ///
        /// Serialize the [`ContractId`](ContractId) into a string form which follows `{shard}.{realm}.{num}` if `evmAddress` is not present
        /// and `{shard}.{realm}.{evmAddress}` if `evmAddress` is present.
        ///
        ///
        /// </summary>
        string ToString()

        /// <summary>
        ///
        /// Serialize the [`ContractId`](ContractId) into its solidity address form.
        ///
        ///
        /// </summary>
        string ToSolidityAddress()

        /// <summary>
        ///
        /// The evm address of this contract.
        ///
        /// Note: This field is only set when `fromEvmAddress()` is used. `fromSolidityAddress()` does not populate this field
        ///
        ///
        /// </summary>
        bytes? EvmAddress { get; }

        /// <summary>
        ///
        /// The num of this ID.
        ///
        ///
        /// </summary>
        long Num { get; }

        /// <summary>
        ///
        /// The realm of this ID.
        ///
        ///
        /// </summary>
        long Realm { get; }

        /// <summary>
        ///
        /// The shard of this ID.
        /// </summary>
        long Shard { get; }

    }
}
