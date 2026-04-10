using Hedera.Hashgraph.Reference.Token;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    public interface ITokenAllowance
    {
        /// <summary>
        /// The account ID of the hbar owner(ie.the grantor of the allowance).
        /// </summary>
        AccountId OwnerAccountId { get; }

        /// <summary>
        /// The token that the allowance pertains to.
        /// </summary>
        TokenId TokenId { get; }

        /// <summary>
        /// The account ID of the spender of the hbar allowance.
        /// </summary>
        AccountId SpenderAccountId { get; }

        /// <summary>
        /// The current balance of the spender's token allowance.
        /// </summary>
        long Amount { get; }
    }
}
