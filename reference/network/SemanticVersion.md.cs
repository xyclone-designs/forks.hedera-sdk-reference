namespace Hedera.Hashgraph.Reference.Network
{
    public interface ISematicVersion
    {
        /// <summary>
        /// Serialize the [`SematicVersion`](#) into its protobuf representation.
        /// </summary>
        abstract static void FromBytes();
        /// <summary>
        /// Deserialize a [`Sem`](#) from its the protobuf representation.
        /// </summary>
        byte[] ToBytes();

        long Major { get; }
        long Minor { get; }
        long Patch { get; }
    }
}
