using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Error
{
    /// <summary>
    /// An Exception thrown on error status by [`TransactionId.getReceipt()`](../core/TransactionId.md#getreceipt--client---transactionreceipt-)
    /// </summary>
    public interface IReceiptStatus
    {
        /// <summary>
        /// The receipt of the transaction that failed; the only initialized field is [`TransactionReceipt.status`](../core/TransactionReceipt.md#status--status)
        /// </summary>
        TransactionReceipt Receipt { get; }

        /// <summary>
        /// The ID of the transaction that failed. This can be `null` if a query fails pre-check without an
        /// associated payment transaction.
        /// </summary>
        TransactionId TransactionId { get; }
    }
}
