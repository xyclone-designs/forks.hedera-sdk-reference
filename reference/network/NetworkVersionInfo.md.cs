using System;

namespace Hedera.Hashgraph.Reference.Network
{
    public class NetworkVersionInfo
    {
        public NetworkVersionInfo(SemanticVersion hapi, SemanticVersion hedera)
        {
            ProtobufVersion = hapi;
            ServicesVersion = hedera;
        }

        /// <summary>
        /// Serialize the [`NetworkVersionInfo`](#) into its protobuf representation.
        /// </summary>
        public static void FromBytes(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deserialize a [`NetworkVersionInfo`](#) from its the protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Hedera API (HAPI) protobuf version recognized by the responding node.
        /// </summary>
        SemanticVersion ProtobufVersion { get; }
        /// <summary>
        /// The version of the Hedera Services software deployed on the responding node.
        /// </summary>
        SemanticVersion ServicesVersion { get; }
    }
}
