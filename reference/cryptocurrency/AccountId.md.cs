using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptography;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// The ID for a cryptocurrency account
    /// </summary>
    public interface IAccountId
    {
        /// <summary>
        /// Construct a [`AccountId`](AccountId.md) with [`shard`](#shard--uint64) and [`realm`](#realm--uint64) being zero.
        /// </summary>
        abstract static void Constructor(long num);

        /// <summary>
        /// Construct a [`AccountId`](AccountId.md) with all fields explicitly set.
        /// </summary>
        abstract static void Constructor(long shard, long realm, long num);

        /// <summary>
        /// Deserialize an account ID from its protobuf representation.
        /// </summary>
        abstract static IAccountId FromBytes(byte[] data);

        /// <summary>
        /// Retrieve the account id from an EVM address.
        /// </summary>
        abstract static IAccountId FromEvmAddress(EvmAddress evmAddress);

        /// <summary>
        /// Construct an account ID from a solidity address.
        /// </summary>
        abstract static IAccountId FromSolidityAddress(string str);

        /// <summary>
        /// Construct an [`AccountId`](AccountId.md) from a string.
        /// `str` must match `^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.((?:[0-9a-fA-F][0-9a-fA-F])+)$`
        /// </summary>
        abstract static IAccountId FromString(string str);

        /// <summary>
        /// Get the checksum for this account ID if it constructed with one.
        /// </summary>
        string GetChecksum();

        /// <summary>
        /// Serialize this ID into its protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// Extract the solidity address.
        /// </summary>
        string ToSolidityAddress();

        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}`
        /// </summary>
        string ToString();

        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}-{checksum}` using the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](../NetworkName.md);
        ///
        /// Note: If the account ID has an `aliasKey`, `toStringWithChecksum` will throw an error
        /// </summary>
        string ToStringWithChecksum(IClient client);

        /// <summary>
        /// Validate the account ID's checksum matches the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](../NetworkName.md);
        ///
        /// Note: If the account ID has an `aliasKey`, `validateChecksum` will throw an error
        /// </summary>
        void ValidateChecksum(IClient client);

        /// <summary>
        /// An alias for the `num` of the account if the account was created from a public key directly.
        /// </summary>
        IPublicKey AliasKey { get; }

        /// <summary>
        /// The EOA 20-byte address to create that is derived from the keccak-256 hash of a ECDSA_SECP256K1 primitive key.
        /// </summary>
        EvmAddress EvmAddress { get; }

        /// <summary>
        /// A non-negative account number unique within its realm
        /// </summary>
        long Num { get; }

        /// <summary>
        /// The realm number (non-negative);
        /// </summary>
        long Realm { get; }

        /// <summary>
        /// The shard number (non-negative);
        /// </summary>
        long Shard { get; }

    }
}
