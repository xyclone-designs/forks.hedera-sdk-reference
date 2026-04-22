using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.File
{
    public interface IFileContentsQuery : IQuery<byte[]>
    {
        /// <summary>
        /// This is the fileID which contents queried for.
        /// </summary>
        IFileId FileId { get; }
    }
}
