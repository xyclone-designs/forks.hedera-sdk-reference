
namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// An ID type that represents a token on a Hedera Hashgraph network.
    /// </summary>
    public interface ISemanticVersion
    {
        /// <summary>
        /// Deserialize a [`Sem`](#) from its the protobuf representation.
        /// </summary>
        byte[] ToBytes();

        public long Major { get; }
        public long Minor { get; }
        public long Patch { get; }
    }
    public interface ISemanticVersion<TSelf> : ISemanticVersion where TSelf : ISemanticVersion<TSelf>
    {
        /// <summary>
        /// Construct a [`TokenId`](#) with all fields explicitly set.
        /// </summary>
        abstract static TSelf CTOR(int major, int minor, int patch);

        /// <summary>
        /// Serialize the [`SematicVersion`](#) into its protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
    }
}
