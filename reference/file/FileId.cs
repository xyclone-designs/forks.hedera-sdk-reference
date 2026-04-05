/// <summary>
/// &gt; class `FileId`
/// An ID type that represents a file on a Hedera Hashgraph network.
/// Construct a [`FileId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
/// --
/// Construct a [`FileId`](#) with all fields explicitly set.
/// --
/// Construct a [`FileId`](#) from a string. The format of the string could be either just
/// a number "4" or dot separated numbers "0.0.4".
/// Deserialize a [`FileId`](#) from its the protobuf representation.
/// Serialize the [`FileId`](#) into its protobuf representation.
/// --
/// The shard of this ID.
/// --
/// The realm of this ID.
/// --
/// The num of this ID.
/// --
/// </summary>
public interface IFileId
{
}