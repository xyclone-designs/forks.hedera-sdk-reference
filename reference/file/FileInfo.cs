/// <summary>
/// &gt; class `FileInfo`
/// Deserialize a [`FileInfo`](#) from its protobuf representation.
/// --
/// Serialize the [`FileInfo`](#) into its protobuf representation.
/// --
/// The ID for which this info belongs to.
/// --
/// The length of this file's contents.
/// --
/// The expiration time of this file. When current time surpasses the expiration time the
/// file is deleted from the network. To update the expiration time use [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md).
/// --
/// Identifies if this file has been deleted.
/// --
/// The keys that are required to sign transactions that mutate this file.
/// --
/// The ID of the ledger which returned this response
/// --
/// </summary>
public interface IFileInfo
{
}