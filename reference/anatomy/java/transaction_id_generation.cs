/// <summary>
/// When submitting transactions especially chunked transactions sometimes the request fails with `TRANSACTION_EXPIRED`. We
/// should strive to prevent such an issue from being reported to the user and instead handle it from within the SDK.
/// Whenever we receive a `TRANSACTION_EXPIRED` status and the user did not manually set the transaction IDs, we should
/// generate a new transaction ID per chunk.
/// Generate new transaction IDs
/// Clear `outerTransactions` list
/// Clear `innerSignedTransactions` list
/// When a transaction fails with `TRANSACTION_EXPIRED` we should generate a new transaction ID for that particular chunk
/// and clear **the chunks** `innerSignedTransactions` and
/// `outerTransactions`.
/// </summary>
public interface Itransaction_id_generation
{
    /// <summary>
    /// `Transaction.fromBytes()`
    /// </summary>
    `Transaction.fromBytes()`;

    /// <summary>
    /// `Transaction.getTransactionHash()`
    /// </summary>
    `Transaction.getTransactionHash()`;

    /// <summary>
    /// `Transaction.getTransactionHashPerNode()`
    /// </summary>
    `Transaction.getTransactionHashPerNode()`;

    /// <summary>
    /// `Transaction.toBytes()`
    /// </summary>
    `Transaction.toBytes()`;

    /// <summary>
    /// `Transaction.addSignature()`
    /// </summary>
    `Transaction.addSignature()`;

    /// <summary>
    /// `Transaction.getTransactionId()`
    /// </summary>
    `Transaction.getTransactionId()`;

    /// <summary>
    /// `Transaction.setTransactionId()`
    /// </summary>
    `Transaction.setTransactionId()`;

    /// <summary>
    /// `Transaction.getSignatures()`
    /// </summary>
    `Transaction.getSignatures()`;

}