namespace Hedera.Hashgraph.Reference.File
{
    /// <summary>
    /// Query a file's current state.
    ///
    /// </summary>
    public interface IFileInfoQuery
    {
        /// <summary>
        ///
        /// This is the file ID for which info will be queried for.
        ///
        /// </summary>
        IFileId FileId { get; }

    }
}
