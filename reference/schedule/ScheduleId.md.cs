using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Schedule
{
    /// <summary>
    /// An ID type that represents a schedule on a Hedera Hashgraph network.
    /// </summary>
    public interface IScheduleId
    {
        /// <summary>
        /// Get the checksum for this schedule ID if it constructed with one.
        /// </summary>
        string GetChecksum();

        /// <summary>
        /// Serialize the [`ScheduleId`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();
        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}`
        /// </summary>
        string ToString();
        /// <summary>
        /// Stringify this ID into `{shard}.{realm}.{num}-{checksum}` using the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
        /// </summary>
        string ToStringWithChecksum(IClient client);

        /// <summary>
        /// Validate the schedule ID's checksum matches the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
        /// </summary>
        void ValidateChecksum(IClient client);

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
    }
    public interface IScheduleId<TSelf> : IScheduleId where TSelf : IScheduleId<TSelf>
    {
        /// <summary>
        /// Construct a [`ScheduleId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        /// </summary>
        abstract static TSelf CTOR(long num);
        /// <summary>
        /// Construct a [`ScheduleId`](#) with all fields explicitly set.
        /// </summary>
        abstract static TSelf CTOR(long shard, long realm, long num);

        /// <summary>
        /// Construct an [`ScheduleId`](#) from a string.
        /// `str` must match `^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.((?:[0-9a-fA-F][0-9a-fA-F])+)$`
        /// </summary>
        abstract static TSelf FromString(string str);
        /// <summary>
        /// Deserialize an schedule ID from its the protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
        /// <summary>
        /// Construct an schedule ID from a solidity address.
        /// </summary>
        abstract static TSelf FromSolidityAddress(string str);
    }
}
