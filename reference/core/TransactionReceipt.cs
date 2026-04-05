/// <summary>
/// &gt; class `TransactionReceipt`
/// The summary of a transaction's result so far. If the transaction has not reached consensus, this
/// result will be necessarily incomplete.
/// Decode a `TransactionReceipt` from an appropriate protobuf encode structure
/// --
/// The byte representation of the encoded protobuf type
/// --
/// Stringification of all the current values
/// --
/// An account ID
/// **Note**: Only present if this receipt is for an `AccountCreateTransaction`
/// --
/// The receipts (if any) of all child transactions spawned by the transaction with the
/// given top-level id, in consensus order. Always empty if the top-level status is UNKNOWN.
/// --
/// A contract ID
/// **Note**: Only present if this receipt is for an `ContractCreateTransaction`
/// --
/// The receipts of processing all transactions with the given id, in consensus time order.
/// --
/// Current exchange rant for Hbar to USD
/// --
/// A file ID
/// **Note**: Only present if this receipt is for an `FileCreateTransaction`
/// --
/// In the receipt of a ScheduleCreate, the id of the newly created Scheduled Entity
/// --
/// In the receipt of a ScheduleCreate or ScheduleSign that resolves to SUCCESS, the
/// TransactionID that should be used to query for the receipt or record of the relevant
/// scheduled transaction
/// --
/// In the receipt of a TokenMint for tokens of type NON\_FUNGIBLE\_UNIQUE, the serial numbers of
/// the newly created NFTs
/// --
/// Status of the submitted transaction.
/// --
/// A token ID
/// **Note**: Only present if this receipt is for an `TokenCreateTransaction`
/// --
/// A topic ID
/// **Note**: Only present if this receipt is for an `TopicCreateTransaction`
/// --
/// The current running hash of the topic
/// **Note**: Only present if this receipt is for an `TopicMessageSubmitTransaction`
/// --
/// The current sequence number of the topic
/// **Note**: Only present if this receipt is for an `TopicMessageSubmitTransaction`
/// --
/// The total supply of tokens for the current token
/// **Note**: Only present if this receipt is for an `TopicMessageSubmitTransaction`
/// --
/// The transaction's ID
/// </summary>
public interface ITransactionReceipt
{
}