using System;

namespace Hedera.Hashgraph.Reference.Contract
{
    public class ContractLogInfo
    {
        public ContractLogInfo(ContractId contractId, byte[] bloom, byte[] topics, byte[] data)
        {
            ContractId = contractId;
            Bloom = bloom;
            Topics = topics;
            Data = data;
        }
        /// <summary>
        /// Deserialize a [`ContractLogInfo`](#) from its protobuf representation.
        /// </summary>
        public static ContractLogInfo FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize the [`ContractLogInfo`](#) into its protobuf representation.
        /// </summary>
        public byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Address of a contract that emitted the event
        /// </summary>
        public ContractId ContractId { get; }

        /// <summary>
        /// Bloom filter for a particular log
        /// </summary>
        public byte[] Bloom { get; }

        /// <summary>
        /// Topics of a particular event
        /// </summary>
        public byte[] Topics { get; }

        /// <summary>
        /// Event data
        /// </summary>
        public byte[] Data { get; }
    }
}
