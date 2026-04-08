namespace Hedera.Hashgraph.Reference.Network
{
    public interface INetworkVersionInfo
    {
        /// <summary>
        /// Serialize the [`NetworkVersionInfo`](#) into its protobuf representation.
        /// </summary>
        abstract static void FromBytes();

        /// <summary>
        /// Deserialize a [`NetworkVersionInfo`](#) from its the protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// The Hedera API (HAPI) protobuf version recognized by the responding node.
        /// </summary>
        ISematicVersion ProtobufVersion { get; }
        /// <summary>
        /// The version of the Hedera Services software deployed on the responding node.
        /// </summary>
        ISematicVersion ServiceVersion { get; }
    }
}
