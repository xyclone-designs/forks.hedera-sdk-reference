/// <summary>
/// &gt; class `TransactionId`
/// The client-generated ID for a transaction.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// // create from..
/// var transactionId = TransactionId.fromString("0.0.23847@1588539964.632521325");
/// var transactionId = new TransactionId(new AccountId(23847), Instant.ofEpochSecond(1588539964);
/// ```
/// ```javascript
/// // create from..
/// const transactionId = TransactionId.fromString("0.0.23847@1588539964.632521325")
/// const transactionId = new TransactionId(new AccountId(0, 0, 23847), new Timestamp(1588539964, 4);
/// ```
/// ```go
/// // create from..
/// txID, err := TransactionIdFromString("0.0.23847@1588539964.632521325")
/// txID := NewTransactionIDWithValidStart(AccountID{Account: 23847}, time.Unix(1588539964, 4))
/// ```
/// &lt;!-- tabs:end --&gt;
/// Construct a transaction ID from an account ID and a timestamp
/// --
/// Construct the transaction ID from a protobuf encoded `TransactionID`
/// --
/// Construct a transaction ID from string
/// **NOTE**: The transaction ID format is
/// `(?&lt;accountId&gt;(\d+.\d+)?\d+)\.(?&lt;timestamp&gt;\d+.\d+)(?&lt;scheduled&gt;\?scheduled)?(?&lt;nonce&gt;/\d+)?`
/// --
/// Generate a transaction ID with the given account ID and a generated timestamp
/// --
/// Fetch the receipt of the transaction.
/// --
/// Fetch the record of the transaction.
/// --
/// Create a transaction id.
/// --
/// Stringify the transaction ID
/// --
/// Convert to a string representation with checksum
/// --
/// Serialize the transaction into protobuf encoded bytes
/// --
/// The account ID of the transaction ID
/// This account pays for the transaction
/// --
/// The identifier for an internal transaction that was spawned as part of handling a user transaction.
/// (These internal transactions share the transactionValidStart and accountID of the user transaction,
/// so a nonce is necessary to give them a unique TransactionID.)
/// An example is when a "parent" ContractCreate or ContractCall transaction calls one or more HTS
/// precompiled contracts; each of the "child" transactions spawned for a precompiled contracts has an id with a
/// different nonce.
/// --
/// The scheduled status of the transaction
/// --
/// The timestamp of this transaction
/// Each transaction ID must have a unique timestamp. Timestamp generation in the SDK fuzzes the current
/// time so collisions are less likely
/// </summary>
public interface ITransactionId
{
}