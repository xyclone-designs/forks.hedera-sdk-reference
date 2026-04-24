using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;
using Hedera.Hashgraph.Reference.Fee;

using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Token
{
    public interface ITokenInfo
    {
        /// <summary>
        /// Serialize the [`TokenInfo`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// ID of the token instance
        /// </summary>
        ITokenId TokenId { get; }
        /// <summary>
        /// The name of the token. It is a string of ASCII only characters
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The symbol of the token. It is a UTF-8 capitalized alphabetical string
        /// </summary>
        string Symbol { get; }
        /// <summary>
        /// The number of decimal places a token is divisible by. Always 0 for tokens of type
        /// NON\_FUNGIBLE\_UNIQUE
        /// </summary>
        long Decimals { get; }
        /// <summary>
        /// For tokens of type FUNGIBLE\_COMMON - the total supply of tokens that are currently in
        /// circulation. For tokens of type NON\_FUNGIBLE\_UNIQUE - the number of NFTs created of this
        /// token instance
        /// </summary>
        ulong TotalSupply { get; }
        /// <summary>
        /// The ID of the account which is set as Treasury
        /// </summary>
        IAccountId TreasuryAccountId { get; }
        /// <summary>
        /// The key which can perform update/delete operations on the token. If empty, the token can be
        /// perceived as immutable (not being able to be updated/deleted)
        /// </summary>
        IKey? AdminKey { get; }
        /// <summary>
        /// The key which can grant or revoke KYC of an account for the token's transactions. If empty,
        /// KYC is not required, and KYC grant or revoke operations are not possible.
        /// </summary>
        IKey? KycKey { get; }
        /// <summary>
        /// The key which can freeze or unfreeze an account for token transactions. If empty, freezing is
        /// not possible
        /// </summary>
        IKey? FreezeKey { get; }
        /// <summary>
        /// The key which can wipe token balance of an account. If empty, wipe is not possible
        /// </summary>
        IKey? WipeKey { get; }
        /// <summary>
        /// The key which can change the supply of a token. The key is used to sign Token Mint/Burn
        /// operations
        /// </summary>
        IKey? SupplyKey { get; }
        /// <summary>
        /// The IKey which can pause and unpause the Token.
        /// </summary>
        IKey? PauseKey { get; }
        /// <summary>
        /// The key which can change the custom fee schedule of the token; if not set, the fee schedule
        /// is immutable
        /// </summary>
        IKey? FeeScheduleKey { get; }
        /// <summary>
        /// The default Freeze status (not applicable, frozen or unfrozen) of Hedera accounts relative to
        /// this token. FreezeNotApplicable is returned if Token Freeze IKey is empty. Frozen is returned
        /// if Token Freeze IKey is set and defaultFreeze is set to true. Unfrozen is returned if Token
        /// Freeze IKey is set and defaultFreeze is set to false
        ///
        /// - `null`: FreezeNotApplicable
        /// - `false`: Unfrozen
        /// - `true`: Frozen
        /// </summary>
        bool? DefaultFreezeStatus { get; }
        /// <summary>
        /// The default KYC status (KycNotApplicable or Revoked) of Hedera accounts relative to this
        /// token. KycNotApplicable is returned if KYC key is not set, otherwise Revoked
        ///
        /// - `null`: KycNotApplicable
        /// - `false`: Revoked
        /// - `true`: Granted
        /// </summary>
        bool? DefaultKycStatus { get; }
        /// <summary>
        /// Specifies whether the token is paused or not. PauseNotApplicable is returned if pauseKey is not set.
        ///
        /// - `null`: PauseNotApplicable
        /// - `false`: Unpaused
        /// - `true`: Paused
        /// </summary>
        bool? PauseStatus { get; }
        /// <summary>
        /// Specifies whether the token was deleted or not
        /// </summary>
        bool IsDeleted { get; }
        /// <summary>
        /// An account which will be automatically charged to renew the token's expiration, at
        /// autoRenewPeriod interval
        /// </summary>
        IAccountId AutoRenewAccountId { get; }
        /// <summary>
        /// The interval at which the auto-renew account will be charged to extend the token's expiry
        /// </summary>
        TimeSpan AutoRenewPeriod { get; }
        /// <summary>
        /// The epoch second at which the token will expire
        /// </summary>
        DateTimeOffset Expiry { get; }
        /// <summary>
        /// The memo associated with the token
        /// </summary>
        string TokenMemo { get; }
        /// <summary>
        /// The token type
        /// </summary>
        TokenType TokenType { get; }
        /// <summary>
        /// The token supply type
        /// </summary>
        TokenSupplyType SupplyType { get; }
        /// <summary>
        /// For tokens of type FUNGIBLE\_COMMON - The Maximum number of fungible tokens that can be in
        /// circulation. For tokens of type NON\_FUNGIBLE\_UNIQUE - the maximum number of NFTs (serial
        /// numbers) that can be in circulation
        /// </summary>
        long MaxSupply { get; }
        /// <summary>
        /// The custom fees to be assessed during a CryptoTransfer that transfers units of this token
        /// </summary>
        ICustomFee? ICustomFee { get; }
        /// <summary>
        /// The ID of the ledger which returned this response
        /// </summary>
        ILedgerId LedgerId { get; }
    }

    /// <summary>
    /// The metadata about a Token instance
    /// </summary>
    public interface ITokenInfo<TSelf> : ITokenInfo where TSelf : ITokenInfo<TSelf>
    {
        abstract static TSelf CTOR(
            ITokenId tokenId,
            string name,
            string symbol,
            uint decimals,
            ulong totalSupply,
            IAccountId treasuryAccountId,
            IKey? adminKey,
            IKey? kycKey,
            IKey? freezeKey,
            IKey? wipeKey,
            IKey? supplyKey,
            IKey? feeScheduleKey,
            bool defaultFreezeStatus,
            bool defaultKycStatus,
            bool isDeleted,
            IAccountId autoRenewAccount,
            TimeSpan autoRenewPeriod,
            DateTimeOffset expirationTime,
            string tokenMemo,
            IEnumerable<ICustomFee> customFees,
            TokenType tokenType,
            TokenSupplyType supplyType,
            long maxSupply,
            IKey? pauseKey,
            bool pauseStatus,
            ILedgerId ledgerId);

        /// <summary>
        /// Deserialize a [`TokenInfo`](#) from its the protobuf representation.
        /// </summary>
        abstract static ITokenInfo FromBytes(byte[] data);
    }
}
