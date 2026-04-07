namespace Hedera.Hashgraph.Reference.Network
{
    /// <summary>
    /// </summary>
    public interface INetworkVersionInfo
    {
        /// <summary>
        ///
        /// Serialize the [`NetworkVersionInfo`](#) into its protobuf representation.
        ///
        ///
        /// </summary>
        abstract static void `fromBytes()`()

        /// <summary>
        ///
        /// Deserialize a [`NetworkVersionInfo`](#) from its the protobuf representation.
        ///
        ///
        /// </summary>
        void `toBytes()`()

        /// <summary>
        ///
        /// The Hedera API (HAPI) protobuf version recognized by the responding node.
        ///
        ///
        /// </summary>
        ISematicVersion ProtobufVersion { get; }

        /// <summary>
        ///
        /// The version of the Hedera Services software deployed on the responding node.
        ///
        /// </summary>
        ISematicVersion ServiceVersion { get; }

    }
}
