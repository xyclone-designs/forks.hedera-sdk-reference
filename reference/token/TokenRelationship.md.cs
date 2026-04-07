namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// </summary>
    public interface ITokenRelationship
    {
        /// <summary>
        ///
        ///
        /// </summary>
        abstract static ITokenRelationship FromBytes(byte[] bytes)

        /// <summary>
        ///
        ///
        /// </summary>
        abstract static byte[] ToBytes()

        /// <summary>
        ///
        ///
        /// </summary>
        ITokenId TokenId { get; }

        /// <summary>
        ///
        ///
        /// </summary>
        string Symbol { get; }

        /// <summary>
        ///
        ///
        /// </summary>
        long Balance { get; }

        /// <summary>
        ///
        ///
        /// </summary>
        bool KycStatus { get; }

        /// <summary>
        ///
        /// </summary>
        bool FreezeStatus { get; }

    }
}
