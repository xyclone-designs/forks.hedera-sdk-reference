namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// An ID type that represents a token on a Hedera Hashgraph network.
    /// </summary>
    public interface ITokenId
    {
        /// <summary>
        /// Construct a [`TokenId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        abstract static void Constructor(long num);

        /// <summary>
        /// Construct a [`TokenId`](#) with all fields explicitly set.
        /// </summary>
        abstract static void Constructor(long shard, long realm, long num);

        /// <summary>
        /// Construct a [`TokenId`](#) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        abstract static ITokenId FromString(string str);

        /// <summary>
        /// Deserialize a [`TokenId`](#) from its the protobuf representation.
        /// </summary>
        abstract static ITokenId FromBytes(byte[] data);

        /// <summary>
        /// Serialize the [`TokenId`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// The shard of this ID.
        /// </summary>
        long Shard { get; }

        /// <summary>
        /// The realm of this ID.
        /// </summary>
        long Realm { get; }

        /// <summary>
        /// The num of this ID.
        /// </summary>
        long Num { get; }
    }
}
