namespace Hedera.Hashgraph.Reference.Cryptography
{
    /// <summary>
    /// Multi-word mnemonic phrases.
    ///
    /// Compatible with (both original and current) Hedera mobile wallets
    /// and MyHbarWallet.
    ///
    /// </summary>
    public interface IMnemonic
    {
        /// <summary>
        ///
        /// Deserialize a mnemonic from a string containing a list of words separated by spaces
        ///
        /// ###### Errors
        ///
        /// - [`BadMnemonic`](../error/BadMnemonic.md) — when the mnemonic contains
        /// words not found in the word list; there is a checksum mismatch; or, an
        /// unexpected number of words.
        ///
        ///
        /// </summary>
        abstract static IMnemonic FromString(string text)

        /// <summary>
        ///
        /// Create a mnemonic from the given list of words.
        ///
        /// ###### Errors
        ///
        /// - [`BadMnemonic`](../error/BadMnemonic.md) — when the mnemonic contains
        /// words not found in the word list; there is a checksum mismatch; or, an
        /// unexpected number of words.
        ///
        ///
        /// </summary>
        abstract static IMnemonic FromWords(string[] words)

        /// <summary>
        ///
        /// Returns a new random 12-word mnemonic from the BIP-39 standard English word list.
        ///
        ///
        /// </summary>
        abstract static IMnemonic Generate12()

        /// <summary>
        ///
        /// Returns a new random 24-word mnemonic from the BIP-39 standard English word list.
        ///
        /// </summary>
        abstract static IMnemonic Generate24()

        /// <summary>
        ///
        /// Derive a private key from the current mnemonic
        ///
        ///
        /// </summary>
        IPrivateKey ToPrivateKey(string passphrase)

        /// <summary>
        ///
        /// Recover an ECDSAsecp256k1 private key from the mnemonic phrase, with an optional passphrase.
        ///
        ///
        /// </summary>
        IPrivateKey ToStandardECDSAsecp256k1PrivateKey(string passphrase, long index)

        /// <summary>
        ///
        /// Recover an Ed25519 private key from the mnemonic phrase, with an optional passphrase.
        ///
        ///
        /// </summary>
        IPrivateKey ToStandardEd25519PrivateKey(string passphrase, long index)

        /// <summary>
        ///
        /// Serializes mnemonic into string where the words are separated by spaces
        ///
        ///
        /// </summary>
        string ToString()

        /// <summary>
        ///
        /// The list of words that define this mnemonic
        /// </summary>
        string[] Words { get; }

    }
}
