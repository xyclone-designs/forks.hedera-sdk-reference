namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// Response when the client sends the node TransactionGetRecordResponse
    ///
    /// </summary>
    public interface ITransactionRecord
    {
        /// <summary>
        ///
        /// Decode a `TransactionRecord` from an appropriate protobuf encode structure
        ///
        ///
        /// </summary>
        abstract static ITransactionRecord FromBytes(byte[] data)

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

    }
}
