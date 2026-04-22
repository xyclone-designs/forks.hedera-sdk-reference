using Hedera.Hashgraph.Reference.Token;

namespace Hedera.Hashgraph.Reference.Network
{
    public interface INetworkVersionInfo
    {
        /// <summary>
        /// Deserialize a [`NetworkVersionInfo`](#) from its the protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// The Hedera API (HAPI) protobuf version recognized by the responding node.
        /// </summary>
        ISemanticVersion ProtobufVersion { get; }
        /// <summary>
        /// The version of the Hedera Services software deployed on the responding node.
        /// </summary>
        ISemanticVersion ServicesVersion { get; }
    }
    public interface INetworkVersionInfo<TSelf> : INetworkVersionInfo where TSelf : INetworkVersionInfo<TSelf>
    {
        abstract static TSelf CTOR(ISemanticVersion hapi, ISemanticVersion hedera);

        /// <summary>
        /// Serialize the [`NetworkVersionInfo`](#) into its protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] bytes);
    }
}
