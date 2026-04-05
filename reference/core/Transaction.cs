/// <summary>
/// &gt; abstract class `Transaction` extends [`Executable`](Exectuable.md) &lt;
/// &gt; [`TransactionResponse`](TransactionResponse.md) &gt;
/// Base class for all transactions that may be submitted to Hedera.
/// Construct a transaction from bytes
/// **NOTE**: The bytes can be a protobuf encoded `TransactionBody`, `Transaction`, `SignedTransaction`
/// or `TransactionList`
/// --
/// Add a signature to the transaction
/// **NOTE**: Requires the transaction to have a single node account ID set
/// --
/// Execute this transaction on the Hedera network, immediately returning
/// metadata about the transaction that was executed.
/// The [`TransactionResponse`](TransactionResponse.md) may be used to fetch
/// the [`TransactionReceipt`](TransactionReceipt.md) or
/// [`TransactionRecord`](TransactionRecord.md)
/// for more information.
/// --
/// Freeze the transaction getting it ready to be signed or executed.
/// Freezing without a client requires a transaction ID and node account IDs to be manually set
/// **NOTE**: Freezing the transaction means it cannot be modified anymore, so make sure to set all the
/// fields correctly before freezing.
/// **NOTE**: Freezing is required for certain operations such as signing and generating hash.
/// --
/// Freeze the transaction with a client.
/// The client's operator will be used to generate a transaction ID, and the client's network will be
/// used to generate a list of node account IDs
/// --
/// Get the transaction signatures
/// --
/// Generate the SHA-384 hash of the transaction
/// **NOTE**: Requires a single node account ID to be set on the transaction.
/// Use `getTransactionHashPerNode()` when node account IDs were not manually set or were set to multiple
/// values
/// --
/// Generate the SHA-384 hash of the transaction per node account ID
/// The key for the returned map is the node account ID
/// --
/// Convert the transaction into a scheduled version
/// --
/// Sign the transaction with the given private key.
/// **NOTE**:Signing with the same private key will be ignored.
/// --
/// Sign the transaction with a public key and a signing callback.
/// **NOTE**:Signing with the same public key will be ignored.
/// --
/// Sign with the client's operator
/// **NOTE**: If the operator has already signed this will be ignored
/// --
/// Encodes this transaction to a byte array that can be later decoded into
/// the same `Transaction`
/// --
/// Тhe maximum transaction fee the client is willing to pay
/// This value is set by the SDK
/// --
/// The number of times to retry submitting this transaction. Transactions are retried when Hedera
/// Hashgraph returns a status code that implies the transaction should be resubmitted, or when a node
/// doesn't respond.
/// --
/// The maximum amount of time to wait between retries
/// --
/// The maximum transaction fee the client is willing to pay.
/// Defaults to `maxTransactionFee` from the `client`.
/// --
/// The minimum amount of time to wait between retries
/// --
/// The list of node account IDs that this transaction will be submitted to.
/// Providing an explicit set of node account IDs interferes with client-side load balancing of the
/// network. By default, the SDK will pre-generate a transaction for 1/3 of the nodes on the network. If
/// a node is down, busy, or otherwise reports a fatal error, the SDK will try again with a different
/// node.
/// --
/// Declares if we should generate new transaction IDs when a transaction fails with
/// `TRANSACTION_EXPIRED`
/// **NOTE**: Defaults to `true`
/// **NOTE**: If transaction IDs are locked, this option is ignored. Transaction IDs can be
/// locked if set manually or if certain methods are called.
/// --
/// The ID for this transaction, which includes the payer's account (the account paying the transaction
/// fee).
/// If two transactions have the same transactionID, they won't both have an effect
/// --
/// Any notes or descriptions that should be put into the record (max length 100).
/// --
/// Duration from the valid start (within the transaction ID) that this
/// transaction is valid for.
/// **NOTE**: Defaults to 120 seconds.
/// </summary>
public interface ITransaction
{
}