using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// Retrieve the latest state of a bytecode.
    /// </summary>
    public interface IContractByteCodeQuery : IQuery<byte[]>
    {
        /// <summary>
        /// This is the contract ID which bytecode will be queried for.
        /// </summary>
        ContractId ContractId { get; set; }
    }
}
