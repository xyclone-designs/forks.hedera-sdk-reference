using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractStateChange
    {
        /// <summary>
        /// Deserialize a [`ContractStateChange`](#) from its protobuf representation.
        /// </summary>
        abstract static IContractStateChange FromBytes(byte[] data);
        /// <summary>
        /// Serialize the [`ContractStateChange`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();
        /// <summary>
        /// The contract to which the storage changes apply to
        /// </summary>
        IContractId ContractId { get; }
        /// <summary>
        /// The list of storage changes.
        /// </summary>
        IList<IStorageChange> StorageChanges { get; }
    }
}
