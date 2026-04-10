using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Request records of all transactions for which the given account was the
    /// effective payer in the last 3 minutes of consensus time and
    /// <tt> ledger.keepRecordsInState=true</tt> was true during
    /// <tt> handleTransaction</tt>.
    /// </summary>
    public interface IAccountRecordsQuery : IQuery<ITransactionRecord[]>
    {
        /// <summary>
        /// The account ID for which the records should be retrieved
        /// </summary>
        AccountId AccountId { get; }
    }
}
