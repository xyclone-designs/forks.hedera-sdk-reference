using Hedera.Hashgraph.Reference.Cryptocurrency;

using System;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// Base class for all queries that may be submitted to Hedera.
    /// </summary>
    public interface IQuery<O>
    {
        /// <summary>
        /// Execute this query on the chosen Hedera network node and return its response.
        ///
        /// The return type of this method is dictated by the derived class.
        /// </summary>
        O Execute(IClient client);

        /// <summary>
        /// Return the cost to execute this query on the chosen Hedera network node.
        /// </summary>
        IHbar GetCost(IClient client);

        /// <summary>
        /// The number of times to retry submitting this transaction. Transactions are retried when Hedera
        /// Hashgraph returns a status code that implies the transaction should be resubmitted, or when a node
        /// doesn't respond.
        /// </summary>
        long MaxAttempts { get; }

        /// <summary>
        /// The maximum amount of time to wait between retries
        /// </summary>
        TimeSpan MaxBackoff { get; }

        /// <summary>
        /// The maximum query payment the client is willing to pay.
        ///
        /// Defaults to `maxQueryPayment` from the `client`.
        /// </summary>
        IHbar? MaxQueryPayment { get; }

        /// <summary>
        /// The minimum amount of time to wait between retries
        /// </summary>
        TimeSpan MinBackoff { get; }

        /// <summary>
        /// The node account IDs that will be queried.
        /// </summary>
        IAccountId[] NodeAccountIds { get; }

        /// <summary>
        /// The transaction ID
        /// </summary>
        ITransactionId PaymentTransactionId { get; }

        /// <summary>
        /// The exact query payment the client will pay for this query.
        ///
        /// If not set, the cost will be dynamically fetched from the network and used (
        /// respecting the `maxQueryPayment` setting).
        /// </summary>
        IHbar? QueryPayment { get; }
    }
}
