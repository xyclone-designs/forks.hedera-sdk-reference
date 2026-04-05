/// <summary>
/// &gt; class `TokenInfo`
/// The metadata about a Token instance
/// Deserialize a [`TokenInfo`](#) from its the protobuf representation.
/// --
/// Serialize the [`TokenInfo`](#) into its protobuf representation.
/// --
/// ID of the token instance
/// --
/// The name of the token. It is a string of ASCII only characters
/// --
/// The symbol of the token. It is a UTF-8 capitalized alphabetical string
/// --
/// The number of decimal places a token is divisible by. Always 0 for tokens of type
/// NON\_FUNGIBLE\_UNIQUE
/// --
/// For tokens of type FUNGIBLE\_COMMON - the total supply of tokens that are currently in
/// circulation. For tokens of type NON\_FUNGIBLE\_UNIQUE - the number of NFTs created of this
/// token instance
/// --
/// The ID of the account which is set as Treasury
/// --
/// The key which can perform update/delete operations on the token. If empty, the token can be
/// perceived as immutable (not being able to be updated/deleted)
/// --
/// The key which can grant or revoke KYC of an account for the token's transactions. If empty,
/// KYC is not required, and KYC grant or revoke operations are not possible.
/// --
/// The key which can freeze or unfreeze an account for token transactions. If empty, freezing is
/// not possible
/// --
/// The key which can wipe token balance of an account. If empty, wipe is not possible
/// --
/// The key which can change the supply of a token. The key is used to sign Token Mint/Burn
/// operations
/// --
/// The Key which can pause and unpause the Token.
/// --
/// The key which can change the custom fee schedule of the token; if not set, the fee schedule
/// is immutable
/// --
/// The default Freeze status (not applicable, frozen or unfrozen) of Hedera accounts relative to
/// this token. FreezeNotApplicable is returned if Token Freeze Key is empty. Frozen is returned
/// if Token Freeze Key is set and defaultFreeze is set to true. Unfrozen is returned if Token
/// Freeze Key is set and defaultFreeze is set to false
/// `null`: FreezeNotApplicable
/// `false`: Unfrozen
/// `true`: Frozen
/// --
/// The default KYC status (KycNotApplicable or Revoked) of Hedera accounts relative to this
/// token. KycNotApplicable is returned if KYC key is not set, otherwise Revoked
/// `null`: KycNotApplicable
/// `false`: Revoked
/// `true`: Granted
/// --
/// Specifies whether the token is paused or not. PauseNotApplicable is returned if pauseKey is not set.
/// `null`: PauseNotApplicable
/// `false`: Unpaused
/// `true`: Paused
/// --
/// Specifies whether the token was deleted or not
/// --
/// An account which will be automatically charged to renew the token's expiration, at
/// autoRenewPeriod interval
/// --
/// The interval at which the auto-renew account will be charged to extend the token's expiry
/// --
/// The epoch second at which the token will expire
/// --
/// The memo associated with the token
/// --
/// The token type
/// --
/// The token supply type
/// --
/// For tokens of type FUNGIBLE\_COMMON - The Maximum number of fungible tokens that can be in
/// circulation. For tokens of type NON\_FUNGIBLE\_UNIQUE - the maximum number of NFTs (serial
/// numbers) that can be in circulation
/// --
/// The custom fees to be assessed during a CryptoTransfer that transfers units of this token
/// --
/// The ID of the ledger which returned this response
/// --
/// </summary>
public interface ITokenInfo
{
}