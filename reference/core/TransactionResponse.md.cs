using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// When the client sends the node a transaction of any kind, the node replies with this,
    /// which simply says that the transaction passed the pre-check (so the node will submit it to
    /// the network) or it failed (so it won't). To learn the consensus result, the
    /// client should later obtain a receipt (free), or can buy a more detailed record (not free).
    /// </summary>
    public interface ITransactionResponse
    {
        /// <summary>
        /// Fetch the receipt for the current transaction ID using the same node account ID
        /// </summary>
        TransactionReceipt GetReceipt(Client client);

        /// <summary>
        /// Create a transaction receipt query for this particular transaction ID and node account ID
        /// </summary>
        ITransactionReceiptQuery GetReceiptQuery();

        /// <summary>
        /// Fetch the transaction record for the current transaction ID using the same node account ID
        ///
        /// **Note**: Will fetch the receipt first, then fetch the record because fetching the record in a
        /// loop will cost more Hbar.
        /// </summary>
        TransactionRecord GetRecord(Client client);

        /// <summary>
        /// Create a transaction record query for this particular transaction ID and node account ID
        /// </summary>
        ITransactionRecordQuery GetRecordQuery();

        /// <summary>
        /// Stringification of all the current values
        /// </summary>
        string ToString();

        /// <summary>
        /// The account ID of the node which the transaction was submitted to
        /// </summary>
        AccountId NodeId { get; }

        /// <summary>
        /// Hash of the transaction
        ///
        /// **Note**: Should be the same as the [`TransactionRecord.transactionHash`](TransactionRecord.md#transactionhash--bytes)
        /// </summary>
        byte[] TransactionHash { get; }

        /// <summary>
        /// Transaction ID of the transaction that was submitted
        /// </summary>
        TransactionId TransactionId { get; }

    }
}
