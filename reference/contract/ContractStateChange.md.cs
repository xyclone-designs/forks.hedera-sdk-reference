using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Contract
{
    public abstract class ContractStateChange
    {
        /// <summary>
        /// Deserialize a [`ContractStateChange`](#) from its protobuf representation.
        /// </summary>
        public static ContractStateChange FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Serialize the [`ContractStateChange`](#) into its protobuf representation.
        /// </summary>
        public abstract byte[] ToBytes();

        /// <summary>
        /// The contract to which the storage changes apply to
        /// </summary>
        public abstract ContractId ContractId { get; }
        /// <summary>
        /// The list of storage changes.
        /// </summary>
        public abstract IList<StorageChange> StorageChanges { get; }
    }
}
