using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractStateChange
    {
        /// <summary>
        /// The contract to which the storage changes apply to
        /// </summary>
        IContractId ContractId { get; }
        /// <summary>
        /// The list of storage changes.
        /// </summary>
        IList<IStorageChange> StorageChanges { get; }

        /// <summary>
        /// Serialize the [`ContractStateChange`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();
    }

    public interface IContractStateChange<TSelf> : IContractStateChange where TSelf : IContractStateChange<TSelf>
    {
        /// <summary>
        /// Deserialize a [`ContractStateChange`](#) from its protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
    }
}
