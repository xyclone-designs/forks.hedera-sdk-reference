/// <summary>
/// &gt; abstract class `Query` &lt; `O` &gt; extends [`Executable`](Exectuable.md) &lt; `0` &gt;
/// Base class for all queries that may be submitted to Hedera.
/// Execute this query on the chosen Hedera network node and return its response.
/// The return type of this method is dictated by the derived class.
/// --
/// Return the cost to execute this query on the chosen Hedera network node.
/// --
/// The number of times to retry submitting this transaction. Transactions are retried when Hedera
/// Hashgraph returns a status code that implies the transaction should be resubmitted, or when a node
/// doesn't respond.
/// --
/// The maximum amount of time to wait between retries
/// --
/// The maximum query payment the client is willing to pay.
/// Defaults to `maxQueryPayment` from the `client`.
/// --
/// The minimum amount of time to wait between retries
/// --
/// The node account IDs that will be queried.
/// --
/// The transaction ID
/// --
/// The exact query payment the client will pay for this query.
/// If not set, the cost will be dynamically fetched from the network and used (
/// respecting the `maxQueryPayment` setting).
/// </summary>
public interface IQuery
{
}