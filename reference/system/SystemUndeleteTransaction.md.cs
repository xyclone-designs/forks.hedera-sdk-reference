using Hedera.Hashgraph.Reference.Contract;
using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.File;

namespace Hedera.Hashgraph.Reference.System
{
    /// <summary>
    /// Undelete a file or smart contract that was deleted by SystemDelete; requires a Hedera
    /// administrative multisignature.
    /// </summary>
    public interface ISystemUndeleteTransaction : ITransaction
    {
        IFileId FileId { get; }
        IContractId ContractId { get; }
        Timestamp ExpirationTime { get; }
    }
}
