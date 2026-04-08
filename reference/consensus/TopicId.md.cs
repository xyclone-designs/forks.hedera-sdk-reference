namespace Hedera.Hashgraph.Reference.Consensus
{
    /// <summary>
    /// An ID type that represents a topic on a Hedera Hashgraph network.
    /// </summary>
    public interface ITopicId
    {
        /// <summary>
        /// Construct a [`TopicId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        abstract static void Constructor(long num);
        /// <summary>
        /// Construct a [`TopicId`](#) with all fields explicitly set.
        /// </summary>
        abstract static void Constructor(long shard, long realm, long num);
        /// <summary>
        /// Construct a [`TopicId`](#) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        abstract static ITopicId FromString(string str);
        /// <summary>
        /// Deserialize a [`TopicId`](#) from its the protobuf representation.
        /// </summary>
        abstract static ITopicId FromBytes(byte[] data);
        /// <summary>
        /// Serialize the [`TopicId`](#) into its protobuf representation.
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
