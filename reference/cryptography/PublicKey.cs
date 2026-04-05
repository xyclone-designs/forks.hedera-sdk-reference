/// <summary>
/// &gt; class `PublicKey` implements [`Key`](Key.md)
/// A public key on the Hedera™ network.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var publicKey = PublicKey.fromString("...");
/// ```
/// ```javascript
/// const publicKey = PublicKey.fromString("...");
/// ```
/// ```go
/// publicKey, err := hedera.PublicKeyFromString("...")
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// Parses a DER encoded Ed25519 or ECDSA public key
/// **Note**: The use of raw bytes for an Ed25519 public key is deprecated; use `fromBytesEd25519()` instead.
/// --
/// Parses a DER encoded Ed25519 or ECDSA public key
/// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
/// --
/// Parses an ECDSA public key from either DER encoded or raw bytes.
/// --
/// Parses an Ed25519 public key from either DER encoded or raw bytes.
/// --
/// Parses a HEX and DER encoded Ed25519 or ECDSA public key
/// **Note**: The use of raw bytes for an Ed25519 public key is deprecated; use `fromStringEd25519()` instead.
/// --
/// Parses a HEX and DER encoded Ed25519 or ECDSA public key
/// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
/// --
/// Parses an ECDSA public key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
/// --
/// Parses an Ed25519 public key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
/// Check if this public key is an ECDSA key.
/// --
/// Check if this public key is an ED25519 key.
/// --
/// Convert this public key into an account ID with a given shard and realm.
/// --
/// Serialize the private key into bytes.
/// **Note**: For `Ed25519` the result of this method call is identical to `toBytesRaw()` while for `ECDSA`
/// this method is identical to `toBytesDer()`.
/// We strongly recommend using `toBytesRaw()` or `toBytesDer()` instead.
/// --
/// Serialize the private key into bytes using SPKI and DER encoding.
/// --
/// Return just the raw bytes for the given key.
/// --
/// Convert this public key into an evm address. The EVM address is This is the rightmost 20 bytes of the 32 byte Keccak-256 hash of the ECDSA public key.
/// --
/// See: [`toStringDer()`](#tostringder----string)
/// --
/// Encodes [`toBytesDer()`](#tobytesder----bytes) into HEX.
/// **Note**: This results in a string which has the key data of the private key prefixed with a header.
/// --
/// Encodes [`toBytesRaw()`](#tobytesraw----bytes) into HEX.
/// --
/// Verify the signature on the message with this public key.
/// --
/// Verify the signatures on all the messages in the Transaction.
/// </summary>
public interface IPublicKey
{
}