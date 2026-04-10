using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// Associates the provided account with the provided tokens. Must be signed by the provided Account's key.
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
    /// If an association between the provided account and any of the tokens already exists, the transaction will resolve to
    /// [`Status.TOKEN_ALREADY_ASSOCIATED_TO_ACCOUNT`](reference/Status.md#TOKEN_ALREADY_ASSOCIATED_TO_ACCOUNT).
    ///
    /// If the provided account's associations count exceed the constraint of maximum token associations per account, the
    /// transaction will resolve to
    /// [`Status.TOKENS_PER_ACCOUNT_LIMIT_EXCEEDED`](reference/Status.md#TOKENS_PER_ACCOUNT_LIMIT_EXCEEDED).
    ///
    /// On success, associations between the provided account and tokens are made and the account is ready to interact with
    /// the tokens.
    /// </summary>
    public interface ITokenAssociateTransaction : ITransaction
    {
        /// <summary>
        /// The tokens to be associated with the provided account
        /// </summary>
        TokenId[] TokenIds { get; }

        /// <summary>
        /// The account to be associated with the provided tokens
        /// </summary>
        AccountId AccountId { get; }
    }
}
