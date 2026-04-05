/// <summary>
/// &gt; class `BadMnemonic` extends `Error`
/// Custom exception for when there are issues with the mnemonic.
/// **Note**: Each language has differing conventions for errors:
/// Java, Dart — `BadMnemonicException`
/// Rust, JavaScript, Python — `BadMnemonicError`
/// Go — `ErrBadMnemonic`
/// C — `HEDERA_BAD_MNEMONIC_UNKNOWN_WORDS`, etc.
/// The mnemonic that failed validation.
/// --
/// The reason for which the mnemonic failed validation.
/// --
/// The indices in the mnemonic that were not found in the BIP-39
/// standard English word list; if, the reason for validation failure was unknown words.
/// </summary>
public interface IBadMnemonic
{
}