namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// The summary of a transaction's result so far. If the transaction has not reached consensus, this
    /// result will be necessarily incomplete.
    ///
    /// </summary>
    public interface ITransactionReceipt
    {
        /// <summary>
        ///
        /// Decode a `TransactionReceipt` from an appropriate protobuf encode structure
        ///
        ///
        /// </summary>
        abstract static ITransactionReceipt FromBytes(byte[] data)

        /// <summary>
        ///
        /// The byte representation of the encoded protobuf type
        ///
        ///
        /// </summary>
        byte[] ToBytes()

        /// <summary>
        ///
        /// Stringification of all the current values
        ///
        ///
        /// </summary>
        string ToString()

        /// <summary>
        ///
        /// An account ID
        ///
        /// **Note**: Only present if this receipt is for an `AccountCreateTransaction`
        ///
        ///
        /// </summary>
        AccountId? AccountId { get; }

    }
}
