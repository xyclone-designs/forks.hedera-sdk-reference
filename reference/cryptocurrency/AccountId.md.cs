using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptography;
using Hedera.Hashgraph.Reference.Token;

using System;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// The ID for a cryptocurrency account
    /// </summary>
    public abstract class AccountId
    {
        /// <summary>
        /// Construct a [`AccountId`](AccountId.md) with [`shard`](#shard--uint64) and [`realm`](#realm--uint64) being zero.
        /// </summary>
        public AccountId(long num) : this(0, 0, num) { }
        /// <summary>
        /// Construct a [`AccountId`](AccountId.md) with all fields explicitly set.
        /// </summary>
        public AccountId(long shard, long realm, long num)
        {
            Shard = shard;
            Realm = realm;
            Num = num;
        }

        /// <summary>
        /// Deserialize an account ID from its protobuf representation.
        /// </summary>
        public static AccountId FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve the account id from an EVM address.
        /// </summary>
        public static AccountId FromEvmAddress(IEvmAddress evmAddress)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Construct an account ID from a solidity address.
        /// </summary>
        public static AccountId FromSolidityAddress(string str)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Construct an [`AccountId`](AccountId.md) from a string.
        /// `str` must match `^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.((?:[0-9a-fA-F][0-9a-fA-F])+)$`
        /// </summary>
        public static AccountId FromString(string str)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the checksum for this account ID if it constructed with one.
        /// </summary>
        public abstract string GetChecksum();

        /// <summary>
        /// Serialize this ID into its protobuf representation.
        /// </summary>
        public abstract byte[] ToBytes();

        /// <summary>
        /// Extract the solidity address.
        /// </summary>
        public abstract string ToSolidityAddress();

        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}`
        /// </summary>
        public override string ToString() => throw new NotImplementedException();

        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}-{checksum}` using the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](../NetworkName.md);
        ///
        /// Note: If the account ID has an `aliasKey`, `toStringWithChecksum` will throw an error
        /// </summary>
        public abstract string ToStringWithChecksum(Client client);

        /// <summary>
        /// Validate the account ID's checksum matches the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](../NetworkName.md);
        ///
        /// Note: If the account ID has an `aliasKey`, `validateChecksum` will throw an error
        /// </summary>
        public abstract void ValidateChecksum(Client client);

        /// <summary>
        /// An alias for the `num` of the account if the account was created from a public key directly.
        /// </summary>
        public IPublicKey? AliasKey { get; }

        /// <summary>
        /// The EOA 20-byte address to create that is derived from the keccak-256 hash of a ECDSA_SECP256K1 primitive key.
        /// </summary>
        public IEvmAddress? EvmAddress { get; }

        /// <summary>
        /// A non-negative account number unique within its realm
        /// </summary>
        public long Num { get; }

        /// <summary>
        /// The realm number (non-negative);
        /// </summary>
        public long Realm { get; }

        /// <summary>
        /// The shard number (non-negative);
        /// </summary>
        public long Shard { get; }
    }
}
