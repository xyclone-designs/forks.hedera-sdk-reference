using System;

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// An ID type that represents a token on a Hedera Hashgraph network.
    /// </summary>
    public class TokenId
    {
        /// <summary>
        /// Construct a [`TokenId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        public TokenId(long num) : this(0, 0, num) { }
        /// <summary>
        /// Construct a [`TokenId`](#) with all fields explicitly set.
        /// </summary>
        public TokenId(long shard, long realm, long num) 
        {
            Shard = shard;
            Realm = realm;
            Num = num;
        }

        /// <summary>
        /// Construct a [`TokenId`](#) from a string. The format of the string could be either just
        /// a number "4" or dot separated numbers "0.0.4".
        /// </summary>
        public static TokenId FromString(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deserialize a [`TokenId`](#) from its the protobuf representation.
        /// </summary>
        public static TokenId FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize the [`TokenId`](#) into its protobuf representation.
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
