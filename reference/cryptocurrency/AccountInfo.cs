/// <summary>
/// &gt; class `AccountInfo`
/// Info about the account (a state proof can be generated for this)
/// Deserialize a [`AccountInfo`](AccountInfo) from its protobuf representation.
/// Serialize the [`AccountInfo`](AccountInfo) into its protobuf representation.
/// --
/// The account ID for which this information applies
/// --
/// The memo associated with the account
/// --
/// The alias of this account
/// --
/// The duration for expiration time will extend every this many seconds. If there are
/// insufficient funds, then it extends as long as possible. If it is empty when it expires,
/// then it is deleted.
/// Defaults to 90 days (or 7,776,000 seconds).
/// --
/// The current balance of account in tinybars
/// --
/// The Contract Account ID comprising both the contract instance and the cryptocurrency
/// account owned by the contract instance, in the format used by Solidity
/// --
/// The ethereum transaction nonce associated with this account.
/// --
/// The TimeStamp time at which this account is set to expire.
/// --
/// All Hbar allowances approved by the account owner.
/// --
/// If true, then this account has been deleted, it will disappear when it expires, and all
/// transactions for it will fail except the transaction to extend its expiration date
/// --
/// If true, no transaction can transfer to this account unless signed by this account's key.
/// --
/// The key for the account, which must sign in order to transfer out, or to modify the
/// account in any way other than extending its expiration date.
/// --
/// The ID of the ledger which returned this response
/// --
/// All livehashes attached to the account (each of which is a hash along with the
/// keys that authorized it and can delete it)
/// --
/// The maximum number of tokens that an Account can be implicitly associated with.
/// --
/// The number of NFTs owned by this account
/// --
/// Deprecated: with no replacement
/// The Account ID of the account to which this is proxy staked. If proxyAccountID is null,
/// or is an invalid account, or is an account that isn't a node, then this account is
/// automatically proxy staked to a node chosen by the network, but without earning payments.
/// If the proxyAccountID account refuses to accept proxy staking , or if it is not currently
/// running a node, then it will behave as if proxyAccountID was null.
/// --
/// The total number of tinybars proxy staked to this account
/// --
/// The threshold amount for which an account record is created (and this account charged
/// for them) for any transaction above this amount.
/// --
/// The threshold amount for which an account record is created (and this account charged
/// for them) for any send/withdraw transaction.
/// --
/// Staking metadata for this contract.
/// --
/// All fungible token allowances approved by the account owner.
/// --
/// All non-fungible token allowances approved by the account owner.
/// --
/// All tokens related to this account.
/// </summary>
public interface IAccountInfo
{
}