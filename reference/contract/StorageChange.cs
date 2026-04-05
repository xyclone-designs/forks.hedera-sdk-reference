/// <summary>
/// &gt; class `StorageChange`
/// The storage slot changed.  Up to 32 bytes, big-endian, zero bytes left trimmed.
/// --
/// The value read from the storage slot.  Up to 32 bytes, big-endian, zero bytes left trimmed.
/// Because of the way SSTORE operations are charged the slot is always read before being written to.
/// --
/// The new value written to the slot.  Up to 32 bytes, big-endian, zero bytes left trimmed.
/// If a value of zero is written the valueWritten will be present but the inner value will be absent.
/// If a value was read and not written this value will not be present.
/// --
/// Deserialize a [`StorageChange`](#) from its protobuf representation.
/// --
/// Serialize the [`StorageChange`](#) into its protobuf representation.
/// --
/// </summary>
public interface IStorageChange
{
}