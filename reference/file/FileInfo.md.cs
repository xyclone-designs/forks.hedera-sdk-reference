using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.File
{
    public interface IFileInfo
    {
        /// <summary>
        /// The ID for which this info belongs to.
        /// </summary>
        public IFileId IFileId { get; }
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
        public ILedgerId LedgerId { get; }

        /// <summary>
        /// Serialize the [`FileInfo`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();
    }
    public interface IFileInfo<TSelf> : IFileInfo where TSelf : IFileInfo<TSelf>
    {
        abstract static TSelf CTOR(IFileId fileId, long size, DateTimeOffset expirationTime, bool isDeleted, IKeyList keys, ILedgerId ledgerId);

        /// <summary>
        /// Deserialize a [`FileInfo`](#) from its protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
    }
}
