using Hedera.Hashgraph.Reference.Contract;
using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// > extends [`Query`](../core/Query.md) < [`Hbar`](../Hbar.md) >
    ///
    /// Get the balance of a cryptocurrency account. This returns only the balance, so it is a smaller
    /// reply than CryptoGetInfo, which returns the balance plus additional information.
    ///
    /// > [!TIP]
    /// > `AccountBalanceQuery` is a completely free query and does not even require
    /// > `setOperator` to be called on the client.
    /// </summary>
    public interface IAccountBalanceQuery : IQuery<Hbar>
    {
        /// <summary>
        /// The account ID for which information is requested
        /// </summary>
        AccountId AccountId { get; }

        /// <summary>
        /// The contract ID for which information is requested
        /// </summary>
        IContractId ContractId { get; }
    }
}
