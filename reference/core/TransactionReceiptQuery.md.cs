namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// Get the receipt of a transaction, given its transaction ID.
    /// <br> Once a transaction reaches consensus, then information about whether it succeeded or failed will be available until the end of the receipt period. <br>
    /// This query is free.
    /// </summary>
    public interface ITransactionReceiptQuery : IQuery<ITransactionReceipt>
    {
        /// <summary>
        /// Whether receipts of processing duplicate transactions should be returned along with the
        /// receipt of processing the first consensus transaction with the given id whose status was
        /// neither <tt>INVALID\_NODE\_ACCOUNT</tt> nor <tt>INVALID\_PAYER\_SIGNATURE</tt>; <b>or</b>, if no
        /// such receipt exists, the receipt of processing the first transaction to reach consensus with
        /// the given transaction id.
        /// </summary>
        bool IncludeDuplicates { get; }

        /// <summary>
        /// Whether the response should include the receipts of any child transactions spawned by the
        /// top-level transaction with the given transactionID.
        /// </summary>
        bool IncludeChildren { get; }

        /// <summary>
        /// The transaction ID to query the receipt for
        /// </summary>
        TransactionId TransactionId { get; }

    }
}
