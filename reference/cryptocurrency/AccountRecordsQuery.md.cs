namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// > extends [`Query`](../core/Query.md) <
    /// > [`TransactionRecord[]`](../core/TransactionRecord.md) >
    ///
    /// Request records of all transactions for which the given account was the
    /// effective payer in the last 3 minutes of consensus time and
    /// <tt>ledger.keepRecordsInState=true</tt> was true during
    /// <tt>handleTransaction</tt>.
    ///
    /// </summary>
    public interface IAccountRecordsQuery
    {
        /// <summary>
        ///
        /// The account ID for which the records should be retrieved
        /// </summary>
        IAccountId AccountId { get; }

    }
}
