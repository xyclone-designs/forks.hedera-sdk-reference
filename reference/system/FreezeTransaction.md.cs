namespace Hedera.Hashgraph.Reference.System
{
    /// <summary>
    /// At consensus, sets the consensus time at which the platform should stop creating events and
    /// accepting transactions, and enter a maintenance window.
    ///
    /// </summary>
    public interface IFreezeTransaction
    {
        /// <summary>
        ///
        ///
        /// </summary>
        Timestamp StartTime { get; }

        /// <summary>
        ///
        /// Deprecated with no replacement
        ///
        ///
        /// </summary>
        Timestamp EndTime { get; }

        /// <summary>
        ///
        /// If set, the file whose contents should be used for a network software update during the maintenance
        /// window.
        ///
        ///
        /// </summary>
        IFileId FileId { get; }

        /// <summary>
        ///
        /// If set, the expected hash of the contents of the update file (used to verify the update).
        ///
        ///
        /// </summary>
        byte[] FileHash { get; }

        /// <summary>
        ///
        /// If set, the expected hash of the contents of the update file (used to verify the update).
        ///
        /// </summary>
        IFreezeType FrezeType { get; }

    }
}
