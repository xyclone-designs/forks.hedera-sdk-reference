// SPDX-License-Identifier: Apache-2.0

namespace Hedera.Hashgraph.Reference.Error
{
    /// <summary>
    /// Possible reason why a [`Mnemonic`](../cryptography/Mnemonic.md) failed validation.
    ///
    /// </summary>
    public enum BadMnemonicReason
    {
        /// <summary>
        ///
        /// The mnemonic did not contain exactly 24 words.
        ///
        ///
        /// </summary>
        `BadLength`,
        /// <summary>
        ///
        /// The checksum encoded in the mnemonic did not match the checksum we just
        /// calculated for that mnemonic.
        ///
        /// 24-word mnemonics have an 8-bit checksum that is appended to the 32 bytes
        /// of source entropy after being calculated from it, before being encoded
        /// into words.
        ///
        /// This could happen if two or more of the words were entered out of the
        /// original order or replaced with another from the standard word list (as
        /// this is only returned if all the words exist in the word list).
        ///
        ///
        /// </summary>
        `ChecksumMismatch`,
        /// <summary>
        ///
        /// The given mnemonic doesn't contain 22 words required to be a legacy mnemonic,
        /// or the words are not in the legacy list.
        ///
        ///
        /// </summary>
        `NotLegacy`,
        /// <summary>
        ///
        /// The mnemonic contained words which were not found in the BIP-39 standard
        /// English word list.
        /// </summary>
        `UnknownWords`,
    }
}
