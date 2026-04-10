using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.File
{
    public interface IFileCreateTransaction : ITransaction
    {
        /// <summary>
        /// This is the key that must sign when mutating the file via [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md)
        /// or [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md) transactions.
        /// If no key is provided the file is immutable any the aforementioned transactions will
        /// err with status code [`UNAUTHORIZED`](reference/Status.md#UNAUTHORIZED).
        /// </summary>
        IKey Keys { get; }

        /// <summary>
        /// These are the contents that will be set upon file creation. The contents cannot
        /// exceed ~4096 bytes. Use [`FileAppendTransaction`](refernce/file/FileAppendTransaction.md)
        /// to set larger contents.
        ///
        /// **Note**. The setter `.setContents()` supports types `bytes` **and** UTF-8 `String`.
        /// </summary>
        byte[] Contents { get; }

        /// <summary>
        /// The expiration time of this file. After this time the file will be deleted. To
        /// prevent file from being deleted a [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md) must be executed with a new expiration time.
        ///
        /// - `Timestmap` is the EPOCH seconds and nanoseconds of a future instant.
        /// </summary>
        DateTimeOffset ExpirationTime { get; }
    }
}
