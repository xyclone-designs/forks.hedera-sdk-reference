using Hedera.Hashgraph.Reference.Contract;
using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.File;

using System;

namespace Hedera.Hashgraph.Reference.System
{
    /// <summary>
    /// Undelete a file or smart contract that was deleted by SystemDelete; requires a Hedera
    /// administrative multisignature.
    /// </summary>
    public interface ISystemUndeleteTransaction : ITransaction
    {
        IFileId IFileId { get; }
        IContractId ContractId { get; }
        DateTimeOffset ExpirationTime { get; }
    }
}
