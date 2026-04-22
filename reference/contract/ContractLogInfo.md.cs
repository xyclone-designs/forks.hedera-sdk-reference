
namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractLogInfo
    {
        /// <summary>
        /// Serialize the [`ContractLogInfo`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// Address of a contract that emitted the event
        /// </summary>
        IContractId ContractId { get; }
        /// <summary>
        /// Bloom filter for a particular log
        /// </summary>
        byte[] Bloom { get; }
        /// <summary>
        /// Topics of a particular event
        /// </summary>
        byte[] Topics { get; }
        /// <summary>
        /// Event data
        /// </summary>
        byte[] Data { get; }
    }

    public interface IContractLogInfo<TSelf> : IContractLogInfo where TSelf : IContractLogInfo<TSelf>
    {
        abstract static TSelf CTOR(IContractId contractId, byte[] bloom, byte[] topics, byte[] data);

        /// <summary>
        /// Deserialize a [`ContractLogInfo`](#) from its protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
    }
}
