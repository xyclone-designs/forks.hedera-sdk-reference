using Hedera.Hashgraph.Reference.Core;
using System;

namespace Hedera.Hashgraph.Reference.Schedule
{
    /// <summary>
    /// The ID for an a cryptocurrency schedule
    /// </summary>
    public class ScheduleId
    {
        /// <summary>
        /// Construct a [`ScheduleId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        public ScheduleId(long num) : this(0, 0, num) { }
        /// <summary>
        /// Construct a [`ScheduleId`](#) with all fields explicitly set.
        /// </summary>
        public ScheduleId(long shard, long realm, long num)
        {
            Shard = shard;
            Realm = realm;
            Num = num;
        }

        /// <summary>
        /// Construct an [`ScheduleId`](#) from a string.
        /// `str` must match `^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.((?:[0-9a-fA-F][0-9a-fA-F])+)$`
        /// </summary>
        public static ScheduleId FromString(string str)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Deserialize an schedule ID from its the protobuf representation.
        /// </summary>
        public static ScheduleId FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Construct an schedule ID from a solidity address.
        /// </summary>
        public static ScheduleId FromSolidityAddress(string str)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the checksum for this schedule ID if it constructed with one.
        /// </summary>
        public virtual string GetChecksum()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Validate the schedule ID's checksum matches the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
        /// </summary>
        public virtual void ValidateChecksum(Client client)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize this ID into its protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}-{checksum}` using the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
        /// </summary>
        public virtual string ToStringWithChecksum(Client client)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The shard number (nonnegative);
        /// </summary>
        public long Shard { get; }
        /// <summary>
        /// The realm number (nonnegative);
        /// </summary>
        public long Realm { get; }
        /// <summary>
        /// A nonnegative schedule number unique within its realm
        ///</summary>
        public long Num { get; }

        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}`
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", Shard, Realm, Num);
        }
    }
}
