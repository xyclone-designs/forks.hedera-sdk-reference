/// <summary>
/// &gt; class `PrivateKey` implements [`Key`](Key.md)
/// A private key on the Hedera™ network.
/// &gt; :bulb: **Tip:** Use "" for an empty passphrase
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var key = PrivateKey.generate();
/// var key = PrivateKey.fromBytes(bytes);
/// var key = PrivateKey.fromString("key");
/// var key = PrivateKey.fromStringDer("derKey");
/// var key = PrivateKey.fromPem(pemString, passphrase);
/// var key = mnemonic.toStandardEd25519PrivateKey("", 0);
/// var key = mnemonic.toStandardECDSAsecp256k1PrivateKey("", 0);
/// ```
/// ```javascript
/// const key = PrivateKey.generate()
/// const key = PrivateKey.fromBytes(bytes);
/// const key = PrivateKey.fromString("key")
/// const key = await PrivateKey.fromPem(pemString, passphrase)
/// const key = await PrivateKey.fromKeystore(keystoreBytes, passphrase)
/// const mnemonic = await Mnemonic.fromString("word1 word2 word3...");
/// const key = PrivateKey.fromMnemonic(mnemonic, passphrase)
/// ```
/// ```go
/// newKey, err := GeneratePrivateKey()
/// newKey, err := PrivateKeyFromBytes(bytes)
/// newKey, err := PrivateKeyFromString("key")
/// newKey, err := PrivateKeyFromKeystore(bytes, passphrase)
/// newKey, err := PrivateKeyFromPem(bytes, passphrase)
/// if err != nil {
/// println(err.Error())
/// }
/// // use "" for an empty passphrase
/// mnemonic, err := hedera.MnemonicFromString("word1 word2 word3...");
/// if err != nil {
/// println(err.Error())
/// }
/// key, err := mnemonic.ToPrivateKey(passphrase)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// Parses a DER encoded Ed25519 or ECDSA private key
/// **Note**: The use of raw bytes for an Ed25519 private key is deprecated; use `fromBytesEd25519()` instead.
/// --
/// Parses a DER encoded Ed25519 or ECDSA private key
/// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
/// --
/// Parses an ECDSA private key from either DER encoded or raw bytes.
/// --
/// Parses an Ed25519 private key from either DER encoded or raw bytes.
/// --
/// Recovers an ed25519 private key from a 24, 22, or 12 word mnemonic. 24 and
/// 12 word mnemonics use a BIP-32 word list and SLIP-10 derivation. 22 word
/// mnemonics use a legacy word list from the original Hedera mobile wallets.
/// --
/// Parse a private key from a PEM encoded string.
/// --
/// Extract the ECDSA private key from a seed.
/// --
/// Extract the ED25519 private key from a seed.
/// --
/// Parses a HEX and DER encoded Ed25519 or ECDSA private key
/// **Note**: The use of raw bytes for an Ed25519 private key is deprecated; use `fromStringEd25519()` instead.
/// --
/// Parses a HEX and DER encoded Ed25519 or ECDSA private key
/// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
/// --
/// Parses an ECDSA private key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
/// --
/// Parses an Ed25519 private key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
/// --
/// Recovers an PrivateKey from an encrypted keystore encoded as a byte slice.
/// --
/// Generates a new Ed25519 private key.
/// Deprecated: Use `generateEd5519()` or `generateEcdsa()` instead.
/// --
/// Generates a new ECDSA private key.
/// --
/// Generates a new Ed25519 private key.
/// [`BadMnemonic`](../error/BadMnemonic.md) — when the mnemonic contains
/// words not found in the word list; there is a checksum mismatch; or, an
/// unexpected number of words.
/// Given a wallet/account index, derive a child key compatible with the iOS and Android wallets.
/// --
/// Check if this private key supports derivation.
/// --
/// Check if this private key is an ECDSA key.
/// --
/// Check if this private key is an ED25519 key.
/// --
/// Derive a legacy child key based on the index
/// --
/// Sign a message with this private key.
/// --
/// Sign a transaction with this private key.
/// --
/// Convert this private key into an account ID with a given shard and realm.
/// Note: The account ID created will use the `publicKey` property of this `PrivateKey`,
/// not the `PrivateKey` bytes.
/// --
/// Serialize the private key into bytes.
/// **Note**: For `Ed25519` the result of this method call is identical to `toBytesRaw()` while for `ECDSA`
/// this method is identical to `toBytesDer()`.
/// We strongly recommend using `toBytesRaw()` or `toBytesDer()` instead.
/// --
/// Serialize the private key into bytes using PKCS and DER encoding.
/// --
/// Return just the raw bytes for the given key.
/// --
/// Converts the private key into a keystore which can be saved on disk
/// --
/// See: [`toStringDer()`](#tostringder----string)
/// --
/// Encodes [`toBytesDer()`](#tobytesder----bytes) into HEX.
/// **Note**: This results in a string which has the key data of the private key prefixed with a header.
/// --
/// Encodes [`toBytesRaw()`](#tobytesraw----bytes) into HEX.
/// Derive a public key from this private key.
/// </summary>
public interface IPrivateKey
{
}