namespace Hedera.Hashgraph.Reference.Error
{
    /// <summary>
    /// Custom exception for when there are issues with the mnemonic.
    ///
    /// **Note**: Each language has differing conventions for errors:
    /// - Java, Dart — `BadMnemonicException`
    /// - Rust, JavaScript, Python — `BadMnemonicError`
    /// - Go — `ErrBadMnemonic`
    /// - C — `HEDERA_BAD_MNEMONIC_UNKNOWN_WORDS`, etc.
    ///
    /// </summary>
    public interface IBadMnemonic
    {
        /// <summary>
        ///
        /// The mnemonic that failed validation.
        ///
        ///
        /// </summary>
        IMnemonic Mnemonic { get; }

        /// <summary>
        ///
        /// The reason for which the mnemonic failed validation.
        ///
        ///
        /// </summary>
        IBadMnemonicReason Reason { get; }

        /// <summary>
        ///
        /// The indices in the mnemonic that were not found in the BIP-39
        /// standard English word list; if, the reason for validation failure was unknown words.
        /// </summary>
        long[] UnknownWordIndicies { get; }

    }
}
