namespace Hedera.Hashgraph.Reference.File
{
    /// <summary>
    /// </summary>
    public interface IFileInfo
    {
        /// <summary>
        ///
        /// Deserialize a [`FileInfo`](#) from its protobuf representation.
        ///
        ///
        /// </summary>
        abstract static IFileInfo FromBytes(byte[] data)

        /// <summary>
        ///
        /// Serialize the [`FileInfo`](#) into its protobuf representation.
        ///
        ///
        /// </summary>
        byte[] ToBytes()

    }
}
