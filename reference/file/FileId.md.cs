using System;

namespace Hedera.Hashgraph.Reference.File
{
    /// <summary>
    /// An ID type that represents a file on a Hedera Hashgraph network.
    /// </summary>
    public class FileId
    {
        /// <summary>
        /// Construct a [`FileId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        public FileId(long num) : this(0, 0, num) { }
        /// <summary>
        /// Construct a [`FileId`](#) with all fields explicitly set.
        /// </summary>
        public FileId(long shard, long realm, long num)
        {
            Shard = shard;
            Realm = realm;
            Num = num;
        }

        /// <summary>
        /// Construct a [`FileId`](#) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        public static FileId FromString(string str)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Deserialize a [`FileId`](#) from its the protobuf representation.
        /// </summary>
        public static FileId FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize the [`FileId`](#) into its protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
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
}
