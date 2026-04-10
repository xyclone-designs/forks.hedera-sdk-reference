using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// Dissociates the provided account with the provided tokens. Must be signed by the provided Account's key.
    ///
    /// If the provided account is not found, the transaction will resolve to
    /// [`Status.INVALID_ACCOUNT_ID`](reference/Status.md#INVALID_ACCOUNT_ID).
    ///
    /// If the provided account has been deleted, the transaction will resolve to
    /// [`Status.ACCOUNT_DELETED`](reference/Status.md#ACCOUNT_DELETED).
    ///
    /// If any of the provided tokens is not found, the transaction will resolve to
    /// [`Status.INVALID_TOKEN_REF`](reference/Status.md#INVALID_TOKEN_REF).
    ///
    /// If any of the provided tokens has been deleted, the transaction will resolve to
    /// [`Status.TOKEN_WAS_DELETED`](reference/Status.md#TOKEN_WAS_DELETED).
    ///
    /// If an association between the provided account and any of the tokens does not exist, the transaction will resolve to
    /// [`Status.TOKEN_NOT_ASSOCIATED_TO_ACCOUNT`](reference/Status.md#TOKEN_NOT_ASSOCIATED_TO_ACCOUNT).
    ///
    /// If the provided account has a nonzero balance with any of the provided tokens, the transaction will resolve to
    /// [`Status.TRANSACTION_REQUIRES_ZERO_TOKEN_BALANCES`](reference/Status.md#TRANSACTION_REQUIRES_ZERO_TOKEN_BALANCES).
    ///
    /// On success, associations between the provided account and tokens are removed.
    /// </summary>
    public interface ITokenDissociateTransaction : ITransaction
    {
        /// <summary>
        /// The tokens to be dissociated with the provided account
        /// </summary>
        TokenId[] TokenIds { get; }

        /// <summary>
        /// The account to be dissociated with the provided tokens
        /// </summary>
        AccountId AccountId { get; }
    }
}
