namespace Hedera.Hashgraph.Reference.File
{
    /// <summary>
    /// </summary>
    public interface IFileContentsQuery
    {
        /// <summary>
        ///
        /// This is the fileID which contents queried for.
        ///
        /// </summary>
        IFileId FileId { get; }

    }
}
