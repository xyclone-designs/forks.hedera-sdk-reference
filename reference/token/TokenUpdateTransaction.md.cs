using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// Updates an already created Token.
    ///
    /// If no value is given for a field, that field is left unchanged. For an immutable tokens (that is, a token created
    /// without an adminKey), only the expiry may be updated. Setting any other field in that case will cause the transaction
    /// status to resolve to
    /// [`Status.TOKEN_IS_IMMUTABlE`](reference/Status.md#TOKEN_IS_IMMUTABlE).
    /// </summary>
    public interface ITokenUpdateTransaction : ITransaction
    {
        /// <summary>
        /// The Token to be updated
        /// </summary>
        ITokenId TokenId { get; }

        /// <summary>
        /// The new Name of the Token. Must be a string of ASCII characters.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The new Symbol of the Token. Must be UTF-8 capitalized alphabetical string identifying the token.
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// The new Treasury account of the Token. If the provided treasury account is not existing or deleted, the response will be
        /// [`Status.INVALID_TREASURY_ACCOUNT_FOR_TOKEN`](reference/Status.md#INVALID_TREASURY_ACCOUNT_FOR_TOKEN).
        /// If successful, the Token balance held in the previous Treasury Account is
        /// transferred to the new one.
        /// </summary>
        IAccountId TreasuryAccountId { get; }

        /// <summary>
        /// The new Admin key of the Token. If Token is immutable, transaction will resolve to
        /// [`Status.TOKEN_IS_IMMUTABlE`](reference/Status.md#TOKEN_IS_IMMUTABlE).
        /// </summary>
        IKey AdminKey { get; }

        /// <summary>
        /// The new KYC key of the Token. If Token does not have currently a KYC key, transaction will resolve to
        /// [`Status.TOKEN_HAS_NO_KYC_KEY`](reference/Status.md#TOKEN_HAS_NO_KYC_KEY).
        /// </summary>
        IKey KycKey { get; }

        /// <summary>
        /// The new Freeze key of the Token. If the Token does not have currently a Freeze key, transaction will resolve to
        /// [`Status.TOKEN_HAS_NO_FREEZE_KEY`](reference/Status.md#TOKEN_HAS_NO_FREEZE_KEY).
        ///
        /// </summary>
        IKey FreezeKey { get; }

        /// <summary>
        /// The new Wipe key of the Token. If the Token does not have currently a Wipe key, transaction will resolve to
        /// [`Status.TOKEN_HAS_NO_WIPE_KEY`](reference/Status.md#TOKEN_HAS_NO_WIPE_KEY).
        /// </summary>
        IKey WipeKey { get; }

        /// <summary>
        /// The new Supply key of the Token. If the Token does not have currently a Supply key, transaction will resolve to
        /// [`Status.TOKEN_HAS_NO_SUPPLY_KEY`](reference/Status.md#TOKEN_HAS_NO_SUPPLY_KEY).
        /// </summary>
        IKey SupplyKey { get; }

        /// <summary>
        /// The new expiry time of the token. Expiry can be updated even if admin key is not set. If the provided expiry is earlier
        /// than the current token expiry, transaction wil resolve to
        /// [`Status.INVALID_EXPIRATION_TIME`](reference/Status.md#INVALID_EXPIRATION_TIME).
        ///
        /// </summary>
        DateTimeOffset ExpirationTime { get; }

        /// <summary>
        /// The new account which will be automatically charged to renew the token's expiration, at autoRenewPeriod interval.
        /// </summary>
        IAccountId AutoRenewAccountId { get; }

        /// <summary>
        /// The new interval at which the auto-renew account will be charged to extend the token's expiry.
        /// </summary>
        TimeSpan AutoRenewPeriod { get; }

        /// <summary>
        /// The IKey which can pause and unpause the Token. If the Token does not currently
        /// have a pause key, transaction will resolve to TOKEN\_HAS\_NO\_PAUSE\_KEY
        /// </summary>
        IKey PauseKey { get; }
    }
}
