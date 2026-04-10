using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Consensus
{
    public interface ITopicDeleteTransaction : ITransaction
    {
        /// <summary>
        /// The `topicId` which should be deleted
        /// </summary>
        TopicId TopicId { get; }
    }
}
