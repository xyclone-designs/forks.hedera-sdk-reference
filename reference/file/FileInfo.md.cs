using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.File
{
    public class FileInfo
    {
        public FileInfo(FileId fileId, long size, DateTimeOffset expirationTime, bool isDeleted, IKeyList keys, LedgerId ledgerId)
        {
            FileId = fileId;
            Size = size;
            ExpirationTime = expirationTime;
            IsDeleted = isDeleted;
            Keys = keys;
            LedgerId = ledgerId;
        }

        /// <summary>
        /// Deserialize a [`FileInfo`](#) from its protobuf representation.
        /// </summary>
        public static FileInfo FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize the [`FileInfo`](#) into its protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ID for which this info belongs to.
        /// </summary>
        public FileId FileId { get; }
        /// <summary>
        /// The length of this file's contents.
        /// </summary>
        public long Size { get; }
        /// <summary>
        /// The expiration time of this file. When current time surpasses the expiration time the
        /// file is deleted from the network.To update the expiration time use[`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md).
        /// </summary>
        public DateTimeOffset ExpirationTime { get; }
        /// <summary>
        /// Identifies if this file has been deleted.
        /// </summary>
        public bool IsDeleted { get; }
        /// <summary>
        /// The keys that are required to sign transactions that mutate this file.
        /// </summary>
        public IKeyList Keys { get; }
        /// <summary>
        /// The ID of the ledger which returned this response
        /// </summary>
        public LedgerId LedgerId { get; }
    }
}
