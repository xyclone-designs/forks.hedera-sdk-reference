using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.File
{
    public interface IFileUpdateTransaction : ITransaction
    {
        /// <summary>
        /// This is the fileID that will be updated.
        /// </summary>
        FileId FileId { get; }

        /// <summary>
        /// These are the new keys of the file. These new keys will be required to sign the
        /// the transactions when mutating the file via [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md)
        /// or [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md) transactions.
        /// If no key is provided the file is immutable any the aforementioned transactions will
        /// err with status code [`UNAUTHORIZED`](reference/Status.md#UNAUTHORIZED).
        /// </summary>
        Key Keys { get; }

        /// <summary>
        /// These are the new contents of the file after execution. The contents cannot
        /// exceed ~4096 bytes. Use [`FileAppendTransaction`](refernce/file/FileAppendTransaction.md)
        /// to set larger contents.
        ///
        /// **Note**. The setter `.setContents()` supports types `bytes` **and** UTF-8 `String`.
        /// <br>
        /// **Note**. The contents will completely override the existing contents of the file.
        /// </summary>
        byte[] Contents { get; }

        /// <summary>
        /// The new expiration time of this file. After this time the file will be deleted. To
        /// prevent file from being deleted another [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md) must be executed with a new expiration time.
        ///
        /// - `Timestmap` is the EPOCH seconds and nanoseconds of a future instant.
        /// </summary>
        DateTimeOffset ExpirationTime { get; }
    }
}
