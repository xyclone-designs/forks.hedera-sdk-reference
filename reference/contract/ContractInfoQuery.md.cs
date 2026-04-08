using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// Retrieve the latest state of a contract.
    /// </summary>
    public interface IContractInfoQuery : IQuery<IContractInfo>
    {
        /// <summary>
        /// This is the contractc ID for which info will be queried for.
        /// </summary>
        IContractId ContractId { get; set; }
    }
}
