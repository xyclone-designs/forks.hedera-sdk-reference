/// <summary>
/// When submitting transactions especially chunked transactions sometimes the request fails with `TRANSACTION_EXPIRED`. We
/// should strive to prevent such an issue from being reported to the user and instead handle it from within the SDK.
/// Whenever we receive a `TRANSACTION_EXPIRED` status and the user did not manually set the transaction IDs, we should
/// generate a new transaction ID per chunk.
/// Generate new transaction IDs
/// Clear `transactions` list
/// Clear `signedTransactions` list
/// When a transaction fails with `TRANSACTION_EXPIRED` we should generate a new transaction ID for that particular chunk
/// and clear **the chunks** `signedTransactions` and
/// `transactions`.
/// </summary>
public interface Itransaction_id_generation
{
    /// <summary>
    /// `TransactionFromBytes()`
    /// </summary>
    `TransactionFromBytes()`;

    /// <summary>
    /// `Transaction.GetTransactionHash()`
    /// </summary>
    `Transaction.GetTransactionHash()`;

    /// <summary>
    /// `Transaction.GetTransactionHashPerNode()`
    /// </summary>
    `Transaction.GetTransactionHashPerNode()`;

    /// <summary>
    /// `Transaction.ToBytes()`
    /// </summary>
    `Transaction.ToBytes()`;

    /// <summary>
    /// `Transaction.AddSignature()`
    /// </summary>
    `Transaction.AddSignature()`;

    /// <summary>
    /// `Transaction.GetTransactionID()`
    /// </summary>
    `Transaction.GetTransactionID()`;

    /// <summary>
    /// `Transaction.SetTransactionID()`
    /// </summary>
    `Transaction.SetTransactionID()`;

    /// <summary>
    /// `Transaction.getSignatures()`
    /// </summary>
    `Transaction.getSignatures()`;

}