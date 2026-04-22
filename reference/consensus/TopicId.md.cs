using System;

namespace Hedera.Hashgraph.Reference.Consensus
{
    /// <summary>
    /// An ID type that represents a topic on a Hedera Hashgraph network.
    /// </summary>
    public interface ITopicId
    {
        /// <summary>
        /// Serialize the [`TopicId`](#) into its protobuf representation.
        /// </summary>
        public byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The shard of this ID.
        /// </summary>
        public long Shard { get; }
        /// <summary>
        /// The realm of this ID.
        /// </summary>
        public long Realm { get; }
        /// <summary>
        /// The num of this ID.
        /// </summary>
        public long Num { get; }
    }

    /// <summary>
    /// An ID type that represents a topic on a Hedera Hashgraph network.
    /// </summary>
    public interface ITopicId<TSelf> : ITopicId where TSelf : class, ITopicId<TSelf>
    {
        /// <summary>
        /// Construct a [`TopicId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        internal abstract static TSelf CTOR(long num);
        /// <summary>
        /// Construct a [`TopicId`](#) with all fields explicitly set.
        /// </summary>
        internal abstract static TSelf CTOR(long shard, long realm, long num);

        /// <summary>
        /// Deserialize a [`TopicId`](#) from its the protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
        /// <summary>
        /// Construct a [`TopicId`](#) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        abstract static TSelf FromString(string str);
    }
}
