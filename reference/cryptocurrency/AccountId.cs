/// <summary>
/// &gt; class `AccountId`
/// The ID for a cryptocurrency account
/// Construct a [`AccountId`](AccountId.md) with [`shard`](#shard--uint64) and [`realm`](#realm--uint64) being zero.
/// --
/// Construct a [`AccountId`](AccountId.md) with all fields explicitly set.
/// --
/// Deserialize an account ID from its protobuf representation.
/// --
/// Retrieve the account id from an EVM address.
/// --
/// Construct an account ID from a solidity address.
/// --
/// Construct an [`AccountId`](AccountId.md) from a string.
/// `str` must match `^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.((?:[0-9a-fA-F][0-9a-fA-F])+)$`
/// Get the checksum for this account ID if it constructed with one.
/// --
/// Serialize this ID into its protobuf representation.
/// --
/// Extract the solidity address.
/// --
/// Stringify this ID into `{shard}.{realm}.{num}`
/// --
/// Stringify this ID into `{shard}.{realm}.{num}-{checksum}` using the client's network.
/// Note: The client must contain a network with a known [`NetworkName`](../NetworkName.md)
/// Note: If the account ID has an `aliasKey`, `toStringWithChecksum` will throw an error
/// --
/// Validate the account ID's checksum matches the client's network.
/// Note: The client must contain a network with a known [`NetworkName`](../NetworkName.md)
/// Note: If the account ID has an `aliasKey`, `validateChecksum` will throw an error
/// An alias for the `num` of the account if the account was created from a public key directly.
/// --
/// The EOA 20-byte address to create that is derived from the keccak-256 hash of a ECDSA_SECP256K1 primitive key.
/// --
/// A non-negative account number unique within its realm
/// --
/// The realm number (non-negative)
/// --
/// The shard number (non-negative)
/// </summary>
public interface IAccountId
{
}