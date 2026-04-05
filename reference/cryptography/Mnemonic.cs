/// <summary>
/// &gt; class `Mnemonic`
/// Multi-word mnemonic phrases.
/// Compatible with (both original and current) Hedera mobile wallets
/// and MyHbarWallet.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var mnemonic = Mnemonic.fromString(words);
/// var privateKey = mnemonic.toStandardEd25519PrivateKey("", 0);
/// var privateKey = mnemonic.toStandardECDSAsecp256k1PrivateKey("", 0);
/// var legacyPrivateKey = mnemonic.toLegacyPrivateKey();
/// ```
/// ```javascript
/// const mnemonic = Mnemonic.fromString(words);
/// const privateKey = await mnemonic.toPrivateKey();
/// const legacyPrivateKey = await mnemonic.toLegacyPrivateKey();
/// ```
/// ```go
/// mnemonic := MnemonicFromString(words);
/// privateKey := mnemonic.ToPrivateKey();
/// legacyPrivateKey := mnemonic.ToLegacyPrivateKey();
/// ```
/// &lt;!-- tabs:end --&gt;
/// Deserialize a mnemonic from a string containing a list of words separated by spaces
/// [`BadMnemonic`](../error/BadMnemonic.md) — when the mnemonic contains
/// words not found in the word list; there is a checksum mismatch; or, an
/// unexpected number of words.
/// --
/// Create a mnemonic from the given list of words.
/// [`BadMnemonic`](../error/BadMnemonic.md) — when the mnemonic contains
/// words not found in the word list; there is a checksum mismatch; or, an
/// unexpected number of words.
/// --
/// Returns a new random 12-word mnemonic from the BIP-39 standard English word list.
/// --
/// Returns a new random 24-word mnemonic from the BIP-39 standard English word list.
/// Derive a private key from the current mnemonic
/// --
/// Recover an ECDSAsecp256k1 private key from the mnemonic phrase, with an optional passphrase.
/// --
/// Recover an Ed25519 private key from the mnemonic phrase, with an optional passphrase.
/// --
/// Serializes mnemonic into string where the words are separated by spaces
/// --
/// The list of words that define this mnemonic
/// </summary>
public interface IMnemonic
{
}