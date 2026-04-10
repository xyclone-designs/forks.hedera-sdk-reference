using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// Burns tokens from the Token's treasury Account. If no Supply IKey is defined, the transaction will resolve to
    /// [`Status.TOKEN_HAS_NO_SUPPLY_KEY`](reference/Status.md#TOKEN_HAS_NO_SUPPLY_KEY).
    /// The operation decreases the Total Supply of the Token. Total supply cannot go below zero.
    /// The amount provided must be in the lowest denomination possible. Example:
    /// Token A has 2 decimals. In order to burn 100 tokens, one must provide amount of 10000. In order to burn 100.55 tokens,
    /// one must provide amount of 10055.
    /// </summary>
    public interface ITokenBurnTransaction : ITransaction
    {
        /// <summary>
        /// The token for which to burn tokens. If token does not exist, transaction results in
        /// [`Status.INVALID_TOKEN_ID`](reference/Status.md#INVALID_TOKEN_ID).
        /// </summary>
        TokenId TokenId { get; }

        /// <summary>
        /// The amount to burn from the Treasury Account. Amount must be a positive non-zero number, not bigger than the token
        /// balance of the treasury account (0; balance], represented in the lowest denomination.
        /// </summary>
        long Amount { get; }
    }
}
