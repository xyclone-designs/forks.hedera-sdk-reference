namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// Get the record for a transaction.
    /// </summary>
    public interface ITransactionRecordQuery : IQuery<ITransactionRecord>
    {
        /// <summary>
        /// Whether the response should include the records of any child transactions spawned by the
        /// top-level transaction with the given transactionID.
        /// </summary>
        bool IncludeChildren { get; }

        /// <summary>
        /// Whether records of processing duplicate transactions should be returned along with the record
        /// of processing the first consensus transaction with the given id whose status was neither
        /// <tt>INVALID\_NODE\_ACCOUNT</tt> nor <tt>INVALID\_PAYER\_SIGNATURE</tt>; <b>or</b>, if no such
        /// record exists, the record of processing the first transaction to reach consensus with the
        /// given transaction id..
        /// </summary>
        bool IncludeDuplicates { get; }

        /// <summary>
        /// The transaction ID to query the record for
        /// </summary>
        ITransactionId TransactionId { get; }
    }
}
