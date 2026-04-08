using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// Wipes the provided amount of tokens from the specified Account. Must be signed by the Token's Wipe key.
    ///
    /// If the provided account is not found, the transaction will resolve to
    /// [`Status.INVALID_ACCOUNT_ID`](reference/Status.md#INVALID_ACCOUNT_ID).
    ///
    /// If the provided account has been deleted, the transaction will resolve to
    /// [`Status.ACCOUNT_DELETED`](reference/Status.md#ACCOUNT_DELETED).
    ///
    /// If the provided token is not found, the transaction will resolve to
    /// [`Status.INVALID_TOKEN_ID`](reference/Status.md#INVALID_TOKEN_ID).
    ///
    /// If the provided token has been deleted, the transaction will resolve to
    /// [`Status.TOKEN_WAS_DELETED`](reference/Status.md#TOKEN_WAS_DELETED).
    ///
    /// If an Association between the provided token and account is not found, the transaction will resolve to
    /// [`Status.TOKEN_NOT_ASSOCIATED_TO_ACCOUNT`](reference/Status.md#TOKEN_NOT_ASSOCIATED_TO_ACCOUNT).
    ///
    /// If Wipe Key is not present in the Token, transaction results in TOKEN_HAS_NO_WIPE_KEY.
    /// [`Status.TOKEN_HAS_NO_WIPE_KEY`](reference/Status.md#TOKEN_HAS_NO_WIPE_KEY).
    ///
    /// If the provided account is the Token's Treasury Account, transaction results in CANNOT_WIPE_TOKEN_TREASURY_ACCOUNT
    /// [`Status.CANNOT_WIPE_TOKEN_TREASURY_ACCOUNT`](reference/Status.md#CANNOT_WIPE_TOKEN_TREASURY_ACCOUNT).
    ///
    /// On success, tokens are removed from the account and the total supply of the token is decreased by the wiped amount.
    ///
    /// The amount provided is in the lowest denomination possible. Example:
    /// Token A has 2 decimals. In order to wipe 100 tokens from account, one must provide amount of 10000. In order to wipe
    /// 100.55 tokens, one must provide amount of 10055.
    /// </summary>
    public interface ITokenWipeTransaction : ITransaction
    {
        /// <summary>
        /// The token for which the account will be wiped. If token does not exist, transaction results in
        /// [`Status.INVALID_TOKEN_ID`](reference/Status.md#INVALID_TOKEN_ID).
        /// </summary>
        ITokenId TokenId { get; }

        /// <summary>
        /// The amount of tokens to wipe from the specified account. Amount must be a positive non-zero number in the lowest
        /// denomination possible, not bigger than the token balance of the account (0; balance]
        /// </summary>
        long Amount { get; }

        /// <summary>
        /// The account to be wiped
        /// </summary>
        IAccountId AccountId { get; }
    }
}
