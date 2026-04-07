namespace Hedera.Hashgraph.Reference.Schedule
{
    /// <summary>
    /// The ID for an a cryptocurrency schedule
    ///
    /// </summary>
    public interface IScheduleId
    {
        /// <summary>
        ///
        /// Construct a [`ScheduleId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
        ///
        ///
        /// </summary>
        abstract static void Constructor(long num)

        /// <summary>
        ///
        /// Construct a [`ScheduleId`](#) with all fields explicitly set.
        ///
        ///
        /// </summary>
        abstract static void Constructor(long shard, long realm, long num)

        /// <summary>
        ///
        /// Construct an [`ScheduleId`](#) from a string.
        /// `str` must match `^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.((?:[0-9a-fA-F][0-9a-fA-F])+)$`
        ///
        ///
        /// </summary>
        abstract static IScheduleId FromString(string str)

        /// <summary>
        ///
        /// Deserialize an schedule ID from its the protobuf representation.
        ///
        ///
        /// </summary>
        abstract static IScheduleId FromBytes(byte[] data)

        /// <summary>
        ///
        /// Construct an schedule ID from a solidity address.
        ///
        ///
        /// </summary>
        abstract static IScheduleId FromSolidityAddress(string str)

        /// <summary>
        ///
        /// Serialize this ID into its protobuf representation.
        ///
        ///
        /// </summary>
        byte[] ToBytes()

        /// <summary>
        ///
        /// Validate the schedule ID's checksum matches the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
        ///
        ///
        /// </summary>
        void ValidateChecksum(IClient client)

        /// <summary>
        ///
        /// Get the checksum for this schedule ID if it constructed with one.
        ///
        ///
        /// </summary>
        string GetChecksum()

        /// <summary>
        ///
        /// Stringify this ID into `{shard}.{realm}.{num}`
        ///
        ///
        /// </summary>
        string ToString()

        /// <summary>
        ///
        /// Stringify this ID into `{shard}.{realm}.{num}-{checksum}` using the client's network.
        ///
        /// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
        ///
        ///
        /// </summary>
        string ToStringWithChecksum(IClient client)

        /// <summary>
        ///
        /// The shard number (nonnegative)
        ///
        ///
        /// </summary>
        long Shard { get; }

        /// <summary>
        ///
        /// The realm number (nonnegative)
        ///
        ///
        /// </summary>
        long Realm { get; }

        /// <summary>
        ///
        /// A nonnegative schedule number unique within its realm
        ///
        /// </summary>
        long Num { get; }

    }
}
