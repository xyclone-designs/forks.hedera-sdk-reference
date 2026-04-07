namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// Grants KYC to the account for the given token. Must be signed by the Token's kycKey.
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
    /// If GrantKyc Key is not present in the Token, transaction results in TOKEN_HAS_NO_GrantKyc_KEY.
    /// [`Status.TOKEN_HAS_NO_KYC_KEY`](reference/Status.md#TOKEN_HAS_NO_KYC_KEY).
    ///
    /// Once executed the Account is marked as KYC Granted.
    ///
    /// </summary>
    public interface ITokenGrantKycTransaction
    {
        /// <summary>
        ///
        /// The token for which this account will be granted KYC. If token does not exist, transaction results in
        /// [`Status.INVALID_TOKEN_ID`](reference/Status.md#INVALID_TOKEN_ID).
        ///
        ///
        /// </summary>
        ITokenId TokenId { get; }

        /// <summary>
        ///
        /// The account to be KYCed
        ///
        /// </summary>
        IAccountId AccountId { get; }

    }
}
