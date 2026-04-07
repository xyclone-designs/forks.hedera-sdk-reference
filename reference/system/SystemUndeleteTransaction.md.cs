namespace Hedera.Hashgraph.Reference.System
{
    /// <summary>
    /// Undelete a file or smart contract that was deleted by SystemDelete; requires a Hedera
    /// administrative multisignature.
    ///
    /// </summary>
    public interface ISystemUndeleteTransaction
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
