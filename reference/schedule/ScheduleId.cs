/// <summary>
/// &gt; class `ScheduleId`
/// The ID for an a cryptocurrency schedule
/// Construct a [`ScheduleId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
/// --
/// Construct a [`ScheduleId`](#) with all fields explicitly set.
/// --
/// Construct an [`ScheduleId`](#) from a string.
/// `str` must match `^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.((?:[0-9a-fA-F][0-9a-fA-F])+)$`
/// --
/// Deserialize an schedule ID from its the protobuf representation.
/// --
/// Construct an schedule ID from a solidity address.
/// --
/// Serialize this ID into its protobuf representation.
/// --
/// Validate the schedule ID's checksum matches the client's network.
/// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
/// --
/// Get the checksum for this schedule ID if it constructed with one.
/// --
/// Stringify this ID into `{shard}.{realm}.{num}`
/// --
/// Stringify this ID into `{shard}.{realm}.{num}-{checksum}` using the client's network.
/// Note: The client must contain a network with a known [`NetworkName`](reference/NetworkName.md)
/// --
/// The shard number (nonnegative)
/// --
/// The realm number (nonnegative)
/// --
/// A nonnegative schedule number unique within its realm
/// --
/// </summary>
public interface IScheduleId
{
}