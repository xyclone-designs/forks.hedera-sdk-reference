using System;

namespace Hedera.Hashgraph.Reference.Network
{
    public class SemanticVersion
    {
        public SemanticVersion(int major, int minor, int patch)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
        }

        /// <summary>
        /// Serialize the [`SematicVersion`](#) into its protobuf representation.
        /// </summary>
        public static void FromBytes(byte[] bytes)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Deserialize a [`Sem`](#) from its the protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        public long Major { get; }
        public long Minor { get; }
        public long Patch { get; }
    }
}
