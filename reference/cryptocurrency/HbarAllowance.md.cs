
namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    public interface IHbarAllowance
    {
        /// <summary>
        /// The account ID of the hbar owner(ie.the grantor of the allowance).
        /// </summary>
        IAccountId OwnerAccountId { get; }

        /// <summary>
        /// The account ID of the spender of the hbar allowance.
        /// </summary>
        IAccountId SpenderAccountId { get; }

        /// <summary>
        /// The current balance of the spender's allowance in tinybars.
        /// </summary>
        IHbar Amount { get; }
    }
}
