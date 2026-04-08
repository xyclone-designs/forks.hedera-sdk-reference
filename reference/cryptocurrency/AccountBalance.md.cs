using Hedera.Hashgraph.Reference.Token;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Response when the client sends the node CryptoGetAccountBalanceQuery
    /// </summary>
    public interface IAccountBalance
    {
        /// <summary>
        /// The current balance, in tinybars.
        /// </summary>
        IHbar Hbars { get; }

        /// <summary>
        /// The token balances possessed by the target account.
        ///
        /// Number of transferable units of the identified token. For token of type FUNGIBLE\_COMMON -
        /// balance in the smallest denomination. For token of type NON\_FUNGIBLE\_UNIQUE - the number of
        /// NFTs held by the account
        /// </summary>
        ITokenId Tokens { get; }

        /// <summary>
        /// The token decimals for each token
        ///
        /// Tokens divide into <tt>10<sup>decimals</sup></tt> pieces
        /// </summary>
        ITokenId TokenDecimals { get; }

    }
}
