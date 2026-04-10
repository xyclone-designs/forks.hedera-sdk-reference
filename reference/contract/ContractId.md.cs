using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// An ID type that represents a contract on a Hedera Hashgraph network.
    /// </summary>
    public abstract class ContractId : IKey
    {
        /// <summary>
        /// Construct a [`ContractId`](ContractId) with [`shard`](#shard--uint64) and [`realm`](#realm--uint64) being zero.
        /// </summary>
        public ContractId(long num) : this(0, 0, num) { }
        /// <summary>
        /// Construct a [`ContractId`](ContractId) with all fields explicitly set.
        /// </summary>
        public ContractId(long shard, long realm, long num)
        {
            Shard = shard;
            Realm = realm;
            Num = num;
        }

        /// <summary>
        /// Deserialize a [`ContractId`](ContractId) from its protobuf representation.
        /// </summary>
        public static ContractId FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Construct a [`ContractId`](ContractId) from a shard, realm, and evm address.
        /// </summary>
        public static ContractId FromEvmAddress(long shard, long realm, string evmAddress)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Construct a [`ContractId`](ContractId) a solidity address.
        ///
        /// Deprecated: Use `fromEvmAddress()` instead.
        /// </summary>
        public static ContractId FromSolidityAddress(string str)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Construct a [`ContractId`](ContractId) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        public static ContractId FromString(string str)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize the [`ContractId`](ContractId) into its protobuf representation.
        /// </summary>
        public abstract byte[] ToBytes();

        /// <summary>
        /// Serialize the [`ContractId`](ContractId) into a string form which follows `{shard}.{realm}.{num}` if `evmAddress` is not present
        /// and `{shard}.{realm}.{evmAddress}` if `evmAddress` is present.
        /// </summary>
        public override string ToString() => throw new NotImplementedException();

        /// <summary>
        /// Serialize the [`ContractId`](ContractId) into its solidity address form.
        /// </summary>
        public abstract string ToSolidityAddress();

        /// <summary>
        /// The evm address of this contract.
        ///
        /// Note: This field is only set when `fromEvmAddress()` is used. `fromSolidityAddress()` does not populate this field
        /// </summary>
        public byte[]? EvmAddress { get; }

        /// <summary>
        /// The num of this ID.
        /// </summary>
        public long Num { get; }

        /// <summary>
        /// The realm of this ID.
        /// </summary>
        public long Realm { get; }

        /// <summary>
        /// The shard of this ID.
        /// </summary>
        public long Shard { get; }

    }
}
