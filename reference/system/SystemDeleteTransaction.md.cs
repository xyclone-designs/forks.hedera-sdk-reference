namespace Hedera.Hashgraph.Reference.System
{
    /// <summary>
    /// Delete a file or smart contract - can only be done with a Hedera administrative multisignature.
    /// When it is deleted, it immediately disappears from the system as seen by the user, but is still
    /// stored internally until the expiration time, at which time it is truly and permanently deleted.
    /// Until that time, it can be undeleted by the Hedera administrative multisignature. When a smart
    /// contract is deleted, the cryptocurrency account within it continues to exist, and is not affected
    /// by the expiration time here.
    ///
    /// </summary>
    public interface ISystemDeleteTransaction
    {
        /// <summary>
        ///
        ///
        /// </summary>
        IFileId FileId { get; }

        /// <summary>
        ///
        ///
        /// </summary>
        IContractId ContractId { get; }

        /// <summary>
        ///
        ///
        /// </summary>
        Timestamp ExpirationTime { get; }

    }
}
