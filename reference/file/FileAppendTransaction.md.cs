namespace Hedera.Hashgraph.Reference.File
{
    /// <summary>
    /// Append contents to a new file that exists on the Hedera Hashgraph network.
    ///
    /// When contents that will be appended are larger than 4096 bytes the transaction
    /// will be chunked into several `FileAppendTransaction`'s implicitly. Whenever the
    /// transaction is executed all the chunked transactions will also be executed awaiting
    /// receipt before each successive transaction. This is done to maintain correctness, but
    /// will increase the time needed to execute this transaction. This transaction also
    /// has the `executeAll()` method because it is chunked; this method is not accessible
    /// by all `Transaction` types.
    ///
    /// </summary>
    public interface IFileAppendTransaction
    {
        /// <summary>
        ///
        /// This is the fileID which contents will be appended to.
        ///
        ///
        /// </summary>
        IFileId FileId { get; }

        /// <summary>
        ///
        /// These are the contents which will be appended to the file.
        ///
        /// **Note**. The setter `.setContents()` supports types `bytes` **and** UTF-8 `String`.
        ///
        /// </summary>
        byte[] Contents { get; }

    }
}
