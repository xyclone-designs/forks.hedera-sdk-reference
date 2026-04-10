using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Error
{
    /// <summary>
    /// Signals that a transaction has failed the pre-check. Before a node submits a transaction to the rest
    /// of the network, it attempts some cheap assertions. This process is called the "pre-check".
    /// </summary>
    public interface IPrecheckStatus
    {
        /// <summary>
        /// The status of the failing transaction
        /// </summary>
        Status Status { get; }

        /// <summary>
        /// The ID of the transaction that failed. This can be `null` if a query fails pre-check without an
        /// associated payment transaction.
        /// </summary>
        TransactionId TransactionId { get; }
    }
}
