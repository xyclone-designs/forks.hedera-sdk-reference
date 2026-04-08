using Hedera.Hashgraph.Reference.Cryptography;

namespace Hedera.Hashgraph.Reference.File
{
    public interface IFileInfo
    {
        /// <summary>
        /// Deserialize a [`FileInfo`](#) from its protobuf representation.
        /// </summary>
        abstract static IFileInfo FromBytes(byte[] data);

        /// <summary>
        /// Serialize the [`FileInfo`](#) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();


        /// <summary>
        /// The ID for which this info belongs to.
        /// </summary>
        IFileId FileId { get; }
        /// <summary>
        /// The length of this file's contents.
        /// </summary>
        long Size { get; }
        /// <summary>
        /// The expiration time of this file. When current time surpasses the expiration time the
        /// file is deleted from the network.To update the expiration time use[`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md).
        /// </summary>
        Timestamp ExpirationTime { get; }

        /// <summary>
        /// Identifies if this file has been deleted.
        /// </summary>
        bool IsDeleted { get; }
        /// <summary>
        /// The keys that are required to sign transactions that mutate this file.
        /// </summary>
        IKeyList Keys { get; }

        /// <summary>
        /// The ID of the ledger which returned this response
        /// </summary>
        ILedgerId LedgerId { get; }
    }
}
