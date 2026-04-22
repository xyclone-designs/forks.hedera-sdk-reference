
namespace Hedera.Hashgraph.Reference.File
{
    /// <summary>
    /// An ID type that represents a file on a Hedera Hashgraph network.
    /// </summary>
    public interface IFileId
    {
        /// <summary>
        /// Serialize the [`FileId`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();

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
    public interface IFileId<TSelf> : IFileId where TSelf : IFileId<TSelf>
    {
        /// <summary>
        /// Construct a [`FileId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        abstract static TSelf CTOR(long num);
        /// <summary>
        /// Construct a [`FileId`](#) with all fields explicitly set.
        /// </summary>
        abstract static TSelf CTOR(long shard, long realm, long num);

        /// <summary>
        /// Construct a [`FileId`](#) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        abstract static TSelf FromString(string str);
        /// <summary>
        /// Deserialize a [`FileId`](#) from its the protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
    }
}
