namespace Hedera.Hashgraph.Reference.Network
{
    /// <summary>
    /// </summary>
    public interface ISematicVersion
    {
        /// <summary>
        ///
        /// Serialize the [`SematicVersion`](#) into its protobuf representation.
        ///
        ///
        /// </summary>
        abstract static void `fromBytes()`()

        /// <summary>
        ///
        /// Deserialize a [`Sem`](#) from its the protobuf representation.
        ///
        ///
        /// </summary>
        void `toBytes()`()

        /// <summary>
        ///
        ///
        /// </summary>
        long Major { get; }

        /// <summary>
        ///
        ///
        /// </summary>
        long Minor { get; }

        /// <summary>
        ///
        /// </summary>
        long Patch { get; }

    }
}
